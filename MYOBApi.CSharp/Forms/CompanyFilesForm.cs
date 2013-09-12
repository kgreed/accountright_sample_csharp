//  Copyright:   Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.
//  Website:     http://www.myob.com
//  Author:      MYOB
//  E-mail:      info@myob.com
//
// Documentation, code and sample applications provided by MYOB Australia are for 
// information purposes only. MYOB Technology Pty Ltd and its suppliers make no 
// warranties, either express or implied, in this document. 
//
// Information in this document or code, including website references, is subject
// to change without notice. Unless otherwise noted, the example companies, 
// organisations, products, domain names, email addresses, people, places, and 
// events are fictitious. 
//
// The entire risk of the use of this documentation or code remains with the user. 
// Complying with all applicable copyright laws is the responsibility of the user. 
//
// Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MYOB.AccountRight.SDK;
using MYOB.AccountRight.SDK.Contracts;
using MYOB.AccountRight.SDK.Services;
using MYOBApi.CSharp.Helpers;

namespace MYOBApi.CSharp.Forms
{
    public partial class CompanyFilesForm : Form
    {
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.

        #region Delegates

        public delegate void SetDataSourceCallback(CompanyFile[] companyFiles);

        #endregion

        private const string LocalApiUrl = "http://localhost:8080/accountright";
        private const string DeveloperKey = "<<DeveloperKey>>";
        private const string DeveloperSecret = "<<DeveloperSecret>>";

        private const bool UseCloud = false;
        private IApiConfiguration _configurationCloud;
        private IApiConfiguration _configurationLocal;

        private IOAuthKeyService _oAuthKeyService;

        public CompanyFilesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that is called when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CompanyFilesLoad(object sender, EventArgs e)
        {
            try
            {
                ShowSpinner();

                //If developer key  enable (see above) and set useCVloud to true the following section manages OAuth token and accessing cloud service 
                if (UseCloud)
                {
                    _configurationCloud = new ApiConfiguration(DeveloperKey, DeveloperSecret, "http://desktop");
                    _oAuthKeyService = new OAuthKeyService();

                    //Get tokens if not stored
                    if (_oAuthKeyService.OAuthResponse == null)
                    {
                        var oauthService = new OAuthService(_configurationCloud);
                        _oAuthKeyService.OAuthResponse =
                            oauthService.GetTokens(OAuthLogin.GetAuthorizationCode(_configurationCloud));
                    }

                    // Load all files from cloud and local simultaneously
                    var cfsCloud = new CompanyFileService(_configurationCloud, null, _oAuthKeyService);
                    cfsCloud.GetRange(OnComplete, OnError);
                }

                _configurationLocal = new ApiConfiguration(LocalApiUrl);
                var cfsLocal = new CompanyFileService(_configurationLocal);
                cfsLocal.GetRange(OnComplete, OnError);

                //' The following two lines can be called to run synchronously rather than async
                //_companyFiles = cfs.GetRange()
                //dgvCompanyFiles.DataSource = _companyFiles
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Method to handle onComplete Event
        /// </summary>
        /// <param name="statusCode"> </param>
        /// <param name="companyFiles"></param>
        /// <remarks>see http://msdn.microsoft.com/en-us/library/ms171728(v=vs.85).aspx </remarks>
        private void OnComplete(HttpStatusCode statusCode, CompanyFile[] companyFiles)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetDataSourceCallback(SetDataSource);
            Invoke(d, new object[] {companyFiles});
        }

        /// <summary>
        /// Method to set the datasource
        /// </summary>
        /// <param name="companyFiles">CompanyFiles Array</param>
        /// <remarks></remarks>
        private void SetDataSource(CompanyFile[] companyFiles)
        {
            //Filter the list to show only files that are supported by v2 of the API
            IEnumerable<CompanyFile> filteredList =
                companyFiles.Where(x => new Version(x.ProductVersion) >= new Version("2013.3"));

            if (dgvCompanyFiles.DataSource == null)
            {
                dgvCompanyFiles.DataSource = filteredList.ToArray();

                if (!UseCloud)
                {
                    HideSpinner();
                }
            }
            else
            {
                dgvCompanyFiles.DataSource = ((CompanyFile[]) dgvCompanyFiles.DataSource).Union(filteredList).ToArray();
                HideSpinner();
            }
        }

        /// <summary>
        /// Callback if there is an error
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="ex"></param>
        /// <remarks></remarks>
        private void OnError(Uri uri, Exception ex)
        {
            MessageBox.Show(ex.Message);
        }


        private void DgvCompanyFilesCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get the selected company file
            CompanyFile companyFile = ((CompanyFile[]) dgvCompanyFiles.DataSource)[e.RowIndex];

            //Get configuration that matches server where file is
            IApiConfiguration config = companyFile.Uri.GetLeftPart(UriPartial.Path).ToLower().Contains(LocalApiUrl)
                                           ? _configurationLocal
                                           : _configurationCloud;

            //Get the credentials for the database
            var frmLogin = new LoginForm();
            frmLogin.ShowDialog(this);
            if (frmLogin.Username.Length > 0)
            {
                ICompanyFileCredentials credentials = new CompanyFileCredentials(frmLogin.Username, frmLogin.Password);

                //load the Invoice List
                var frmInvoiceList = new InvoiceListForm();
                frmInvoiceList.Initialise(config, companyFile, credentials, _oAuthKeyService);
                frmInvoiceList.Show();
            }
        }


        protected void ShowSpinner()
        {
            picSpinner.BringToFront();
            picSpinner.Show();
        }

        protected void HideSpinner()
        {
            picSpinner.Hide();
        }
    }
}
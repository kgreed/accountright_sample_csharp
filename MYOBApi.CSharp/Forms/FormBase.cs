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
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MYOB.AccountRight.SDK;
using MYOB.AccountRight.SDK.Contracts;

namespace MYOBApi.CSharp.Forms
{
    public partial class FormBase : Form
    {
        // This delegate enables asynchronous calls to return to UI thread

        #region Delegates

        public delegate void SetHideSpinnerCallback();

        #endregion

        protected CompanyFile MyCompanyFile;
        protected IApiConfiguration MyConfiguration;
        protected ICompanyFileCredentials MyCredentials;

        protected IOAuthKeyService MyOAuthKeyService;

        public FormBase()
        {
            InitializeComponent();
        }

        public void Initialise(IApiConfiguration configuration, CompanyFile companyFile,
                               ICompanyFileCredentials credentials, IOAuthKeyService oAuthKeyService)
        {
            // Add any initialization after the InitializeComponent() call.
            MyConfiguration = configuration;
            MyCompanyFile = companyFile;
            MyCredentials = credentials;
            MyOAuthKeyService = oAuthKeyService;

            Text = string.Format("{0} - {1}", companyFile.Name, companyFile.Uri);
        }

        private void CloseBtnClick(Object sender, EventArgs e)
        {
            Close();
        }

        protected void ShowSpinner()
        {
            if (picSpinner.InvokeRequired)
            {
                //Invoke the SetDataSource method on the UI thread
                var d = new SetHideSpinnerCallback(HideSpinner);
                Invoke(d, new object());
            }
            else
            {
                picSpinner.BringToFront();
                picSpinner.Show();
            }
        }

        protected void HideSpinner()
        {
            if (picSpinner.InvokeRequired)
            {
                //Invoke the SetDataSource method on the UI thread
                var d = new SetHideSpinnerCallback(HideSpinner);
                Invoke(d);
            }
            else
            {
                picSpinner.Hide();
            }
        }

        #region "Error callback"

        /// <summary>
        /// Callback if there is an error
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="ex"></param>
        /// <remarks></remarks>
        protected void OnError(Uri uri, Exception ex)
        {
            //Display the formatted message
            switch (ex.GetType().Name)
            {
                case "WebException":
                    MessageBox.Show(FormatMessage((WebException) ex));
                    break;
                case "ApiCommunicationException":
                    MessageBox.Show(FormatMessage((WebException) ex.InnerException));
                    break;
                case "ApiOperationException":
                    MessageBox.Show(ex.Message);
                    break;
                default:
                    MessageBox.Show(ex.Message);
                    break;
            }

            HideSpinner();
        }


        private string FormatMessage(WebException webEx)
        {
            var responseText = new StringBuilder();
            responseText.AppendLine(webEx.Message);
            responseText.AppendLine();

            // Call method 'GetResponseStream' to obtain stream associated with the response object 
            WebResponse response = webEx.Response;
            Stream receiveStream = response.GetResponseStream();

            Encoding encode = Encoding.GetEncoding("utf-8");

            // Pipe the stream to a higher level stream reader with the required encoding format. 
            var readStream = new StreamReader(receiveStream, encode);
            var read = new Char[257];

            // Read 256 charcters at a time    . 
            int count = readStream.Read(read, 0, 256);
            responseText.AppendLine("HTML...");

            while (count > 0)
            {
                // Dump the 256 characters on a string and display the string onto the console. 
                var str = new String(read, 0, count);
                responseText.Append(str);
                count = readStream.Read(read, 0, 256);
            }
            responseText.Append("");

            // Release the resources of stream object.
            readStream.Close();

            // Release the resources of response object.
            response.Close();

            return responseText.ToString();
        }

        #endregion
    }
}
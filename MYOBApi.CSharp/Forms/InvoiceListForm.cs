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
using System.Linq;
using System.Windows.Forms;
using MYOB.AccountRight.SDK.Services.Sale;
using MYOB.AccountRight.SDK.Contracts.Version2;
using MYOB.AccountRight.SDK.Contracts.Version2.Sale;

namespace MYOBApi.CSharp.Forms
{
    public partial class InvoiceListForm : FormBase
    {

              // This delegate enables asynchronous calls to return to UI thread
        public delegate void SetDataSourceCallback(PagedCollection<Invoice> invoices);

        private const double PageSize = 500;
        private int _currentPage = 1;
        private int _totalPages;

        /// <summary>
        /// On Form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void InvoiceListFormLoad(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// Refresh the data from the API by sending Async calls
        /// </summary>
        /// <remarks></remarks>
        public void RefreshData()
        {
            ShowSpinner();

            string pageFilter = string.Format("$top={0}&$skip={1}&$orderby=Date desc", PageSize,
                                              PageSize*(_currentPage - 1));

            var invoiceSvc = new InvoiceService(MyConfiguration, null, MyOAuthKeyService);
            invoiceSvc.GetRange(MyCompanyFile, pageFilter, MyCredentials, OnComplete, OnError);
        }


        /// <summary>
        /// Method called on Async complete
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="invoices"></param>
        /// <remarks></remarks>
        private void OnComplete(System.Net.HttpStatusCode statusCode,
                                PagedCollection<Invoice> invoices)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetDataSourceCallback(SetDataSource);
            Invoke(d, new object[] {invoices});
        }


        /// <summary>
        /// Method to set the datasource
        /// </summary>
        /// <param name="invoices">Pages collection of invoices</param>
        /// <remarks></remarks>
        private void SetDataSource(PagedCollection<Invoice> invoices)
        {
            _totalPages = (int) Math.Ceiling(((Double)invoices.Count)/PageSize);

            BtnPageLeft.Enabled = (_currentPage > 1);
            BtnPageRight.Enabled = (_currentPage < _totalPages);
            TextPage.Text = string.Format("Page {0} of {1}", _currentPage, _totalPages);


            //Fill the four grids
            GridAllInvoices.DataSource = invoices.Items;
            GridOpenInvoices.DataSource = invoices.Items.Where(s => s.Status == SaleStatus.Open).ToArray();
            GridCreditInvoices.DataSource = invoices.Items.Where(s => s.Status == SaleStatus.Credit).ToArray();
            GridClosedInvoices.DataSource = invoices.Items.Where(s => s.Status == SaleStatus.Closed).ToArray();

            HideSpinner();
        }

        private void BtnPageLeftClick(Object sender, EventArgs e)
        {
            _currentPage -= 1;
            RefreshData();
        }

        private void BtnPageRightClick(Object sender, EventArgs e)
        {
            _currentPage += 1;
            RefreshData();
        }

        private void BtnNewClick(Object sender, EventArgs e)
        {
            var frmInvoice = new InvoiceForm();
            frmInvoice.Initialise(MyConfiguration, MyCompanyFile, MyCredentials, MyOAuthKeyService);
            frmInvoice.Show(this);
        }



        private void GridAllInvoicesCellContentDoubleClick(object sender,DataGridViewCellEventArgs e)
        {
            //Get the selected Invoice         
            var invoice = ((Invoice[])GridAllInvoices.DataSource)[e.RowIndex];


            switch (invoice.InvoiceType)
            {
                case InvoiceLayoutType.Service:
                    //load the Invoice List
                    var frmInvoice = new InvoiceForm();
                    frmInvoice.Initialise(MyConfiguration, MyCompanyFile, MyCredentials, MyOAuthKeyService);
                    frmInvoice.Show(invoice);
                    break;
                default:
                    MessageBox.Show("Only Service Invoices Have been implemented");
                    break;
            }


        }



    }
}
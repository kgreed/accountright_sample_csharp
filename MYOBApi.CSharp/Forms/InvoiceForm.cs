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
using MYOB.AccountRight.SDK.Contracts.Version2;
using MYOB.AccountRight.SDK.Contracts.Version2.Contact;
using MYOB.AccountRight.SDK.Contracts.Version2.GeneralLedger;
using MYOB.AccountRight.SDK.Contracts.Version2.Sale;
using MYOB.AccountRight.SDK.Services.Contact;
using MYOB.AccountRight.SDK.Services.GeneralLedger;
using MYOB.AccountRight.SDK.Services.Sale;

namespace MYOBApi.CSharp.Forms
{
    public partial class InvoiceForm : FormBase
    {
        // This delegate enables asynchronous calls to return to UI thread

        #region Delegates

        public delegate void SetAccountsCallback(PagedCollection<Account> customers);

        public delegate void SetCustomersCallback(PagedCollection<Customer> customers);

        public delegate void SetJobsCallback(PagedCollection<Job> customers);

        public delegate void SetSaveCallback(string newURI);

        public delegate void SetTaxCodesCallback(PagedCollection<TaxCode> customers);

        #endregion

        private Invoice _invoice;
        private int _prereqCount;

        private void InvoiceFormLoad(object sender, EventArgs e)
        {
            ChkTaxInclusive.Checked = true;
            DtDate.Value = DateTime.Now;

            LoadCustomers();
            LoadAccounts();
            LoadJobs();
            LoadTaxCodes();
            ShowSpinner();
        }


        public void Show(Invoice invoice)
        {
            _invoice = invoice;
            Show();
        }

        private void DoBind()
        {
            _prereqCount += 1;
            if (_prereqCount == 4)
            {
                BindInvoice();
                HideSpinner();
            }
        }


        private void BindInvoice()
        {
            if ((_invoice != null))
            {
                var serviceInvoiceSvc = new ServiceInvoiceService(MyConfiguration,
                                                                  null,
                                                                  MyOAuthKeyService);
                ServiceInvoice serviceInvoice = serviceInvoiceSvc.Get(MyCompanyFile, _invoice.UID, MyCredentials);

                //Set the default value
                var customers =
                    CmboCustomer.DataSource as PagedCollection<Customer>;

                if (customers != null)
                {
                    for (int i = 0; i <= customers.Count; i++)
                    {
                        Customer customer = customers.Items[i];
                        if (customer.UID == serviceInvoice.Customer.UID)
                        {
                            CmboCustomer.SelectedIndex = i;
                            break;
                        }
                    }
                }
                BsServiceInvoice.DataSource = serviceInvoice;
                GrdServiceLines.DataSource = FlattenLines(serviceInvoice.Lines);
            }
        }

        private void BtnRecordClick(Object sender, EventArgs e)
        {
            var serviceInvoiceSvc = new ServiceInvoiceService(MyConfiguration, null,
                                                              MyOAuthKeyService);
            var serviceInvoice = new ServiceInvoice();

            if ((_invoice == null))
            {
                var customerLnk = new CustomerLink {UID = (Guid) CmboCustomer.SelectedValue};
                serviceInvoice.Customer = customerLnk;
                serviceInvoice.ShipToAddress = TxtAddress.Text;
                serviceInvoice.Number = TxtInvoiceNo.Text;
                serviceInvoice.Date = DtDate.Value;
                serviceInvoice.IsTaxInclusive = ChkTaxInclusive.Checked;

                var lines = new List<ServiceInvoiceLine>();

                foreach (DataGridViewRow row in GrdServiceLines.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var line = new ServiceInvoiceLine
                                       {
                                           Type = InvoiceLineType.Transaction,
                                           Description = (string) row.Cells["ColDescription"].Value,
                                           Total = Convert.ToDecimal(row.Cells["ColAmount"].Value)
                                       };

                        if ((row.Cells["ColAccount"].Value == null))
                        {
                            MessageBox.Show("you must select an account on each row");
                            return;
                        }
                        var accountlnk = new AccountLink {UID = (Guid) row.Cells["ColAccount"].Value};
                        line.Account = accountlnk;

                        if ((row.Cells["ColTax"].Value == null))
                        {
                            MessageBox.Show("you must select a taxcode on each row");
                            return;
                        }
                        var taxcodelnk = new TaxCodeLink {UID = (Guid) row.Cells["ColTax"].Value};
                        line.TaxCode = taxcodelnk;

                        if ((row.Cells["ColJob"].Value != null))
                        {
                            var joblnk = new JobLink {UID = (Guid) row.Cells["ColJob"].Value};
                            line.Job = joblnk;
                        }

                        lines.Add(line);
                    }
                }


                serviceInvoice.Lines = lines;
                serviceInvoiceSvc.Insert(MyCompanyFile, serviceInvoice, MyCredentials, OnSaveComplete, OnError);
                ShowSpinner();
            }
        }

        /// <summary>
        /// Method called on Async complete
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="newURI"></param>
        /// <remarks></remarks>
        private void OnSaveComplete(HttpStatusCode statusCode, string newURI)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetSaveCallback(SaveCallback);
            Invoke(d, new object[] {newURI});
        }

        private void SaveCallback(string newURI)
        {
            MessageBox.Show("Saved: " + Environment.NewLine + newURI);
            HideSpinner();

            if ((Owner != null))
            {
                ((InvoiceListForm) Owner).RefreshData();
            }
            Close();
        }

        private static List<FlatServiceinvoiceLine> FlattenLines(IEnumerable<ServiceInvoiceLine> serviceInvoiceLines)
        {
            var flattenedLines = new List<FlatServiceinvoiceLine>();

            foreach (ServiceInvoiceLine line in serviceInvoiceLines)
            {
                var flatLine = new FlatServiceinvoiceLine
                                   {
                                       RowId = line.RowID,
                                       Description = line.Description,
                                       AccountUid = line.Account.UID,
                                       Total = line.Total,
                                       TaxUid = line.TaxCode.UID,
                                       RowVersion = line.RowVersion
                                   };
                if (line.Job != null)
                {
                    flatLine.JobUid = line.Job.UID;
                }
                flattenedLines.Add(flatLine);
            }

            return flattenedLines;
        }

        private void GrdServiceLinesDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (((e.Exception) is ArgumentException))
            {
                //ignore error for binding
                e.ThrowException = false;
            }
            else
            {
                e.ThrowException = true;
            }
        }

        #region "Customer List"

        private void LoadCustomers()
        {
            var customerSvc = new CustomerService(MyConfiguration, null, MyOAuthKeyService);
            customerSvc.GetRange(MyCompanyFile, null, MyCredentials, OnCustomerComplete, OnError);
        }

        /// <summary>
        /// Method called on Async complete
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="customers"></param>
        /// <remarks></remarks>
        private void OnCustomerComplete(HttpStatusCode statusCode, PagedCollection<Customer> customers)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetCustomersCallback(SetCustomerDataSource);
            Invoke(d, new object[] {customers});
        }

        /// <summary>
        /// Method to set the datasource
        /// </summary>
        /// <param name="customers">Pages collection of invoices</param>
        /// <remarks></remarks>
        private void SetCustomerDataSource(PagedCollection<Customer> customers)
        {
            //Fill the dropdown
            CmboCustomer.DataSource = customers.Items;
            DoBind();
        }


        /// <summary>
        /// Formats the display of the items in combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>
        private void CmboCustomerFormat(object sender, ListControlConvertEventArgs e)
        {
            var customer = e.ListItem as Customer;

            if (customer != null && customer.IsIndividual)
            {
                e.Value = customer.DisplayID + ": " + customer.FirstName + " " + customer.LastName;
            }
            else
            {
                if (customer != null) e.Value = customer.DisplayID + ": " + customer.CompanyName;
            }
        }

        private void CmboCustomerSelectedIndexChanged(object sender, EventArgs e)
        {
            if ((CmboCustomer.SelectedItem != null))
            {
                var customer = (Customer) CmboCustomer.SelectedItem;
                Address address = customer.Addresses.FirstOrDefault();
                if (address != null)
                    TxtAddress.Text = string.Format("{0}{1}{2}{1}{3}", address.Street, Environment.NewLine, address.City,
                                                    address.PostCode);
            }
            else
            {
                TxtAddress.Text = "";
            }
        }

        #endregion

        #region "Account List"

        /// <summary>
        /// Call API to return a list of Income Accounts only
        /// </summary>
        /// <remarks></remarks>
        private void LoadAccounts()
        {
            var accountSvc = new AccountService(MyConfiguration, null,
                                                MyOAuthKeyService);
            accountSvc.GetRange(MyCompanyFile, "$filter=Classification eq 'Income' and IsHeader eq false", MyCredentials,
                                OnAccountComplete, OnError);
        }

        /// <summary>
        /// Method called on Async complete
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="accounts"></param>
        /// <remarks></remarks>
        private void OnAccountComplete(HttpStatusCode statusCode, PagedCollection<Account> accounts)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetAccountsCallback(SetAccountDataSource);
            Invoke(d, new object[] {accounts});
        }

        /// <summary>
        /// Method to set the datasource
        /// </summary>
        /// <param name="accounts">Pages collection of invoices</param>
        /// <remarks></remarks>
        private void SetAccountDataSource(PagedCollection<Account> accounts)
        {
            //Fill the dropdown
            ColAccount.DataSource = accounts.Items;
            ColAccount.DisplayMember = "Name";
            ColAccount.ValueMember = "UID";
            ColAccount.ValueType = typeof (Guid);
            DoBind();
        }

        #endregion

        #region "Job List"

        private void LoadJobs()
        {
            var jobSvc = new JobService(MyConfiguration, null,
                                        MyOAuthKeyService);
            jobSvc.GetRange(MyCompanyFile, "$filter=IsHeader eq false", MyCredentials, OnJobComplete, OnError);
        }

        /// <summary>
        /// Method called on Async complete
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="jobs"></param>
        /// <remarks></remarks>
        private void OnJobComplete(HttpStatusCode statusCode, PagedCollection<Job> jobs)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetJobsCallback(SetJobDataSource);
            Invoke(d, new object[] {jobs});
        }

        /// <summary>
        /// Method to set the datasource
        /// </summary>
        /// <param name="jobs">Pages collection of invoices</param>
        /// <remarks></remarks>
        private void SetJobDataSource(PagedCollection<Job> jobs)
        {
            //Fill the dropdown
            ColJob.DataSource = jobs.Items;
            ColJob.DisplayMember = "Name";
            ColJob.ValueMember = "UID";
            ColJob.ValueType = typeof (Guid);

            DoBind();
        }

        #endregion

        #region "TaxCode List"

        private void LoadTaxCodes()
        {
            var taxCodeSvc = new TaxCodeService(MyConfiguration, null,
                                                MyOAuthKeyService);
            taxCodeSvc.GetRange(MyCompanyFile, null, MyCredentials, OnTaxCodeComplete, OnError);
        }

        /// <summary>
        /// Method called on Async complete
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="taxCodes"></param>
        /// <remarks></remarks>
        private void OnTaxCodeComplete(HttpStatusCode statusCode, PagedCollection<TaxCode> taxCodes)
        {
            //Invoke the SetDataSource method on the UI thread
            var d = new SetTaxCodesCallback(SetTaxCodesDataSource);
            Invoke(d, new object[] {taxCodes});
        }

        /// <summary>
        /// Method to set the datasource
        /// </summary>
        /// <param name="taxCodes">Pages collection of invoices</param>
        /// <remarks></remarks>
        private void SetTaxCodesDataSource(PagedCollection<TaxCode> taxCodes)
        {
            //Fill the dropdown
            ColTax.DataSource = taxCodes.Items;
            ColTax.DisplayMember = "Code";
            ColTax.ValueMember = "UID";
            ColJob.ValueType = typeof (Guid);

            DoBind();
        }

        #endregion

        #region Nested type: FlatServiceinvoiceLine

        private struct FlatServiceinvoiceLine
        {
            public int RowId { get; set; }
            public string Description { get; set; }
            public Guid AccountUid { get; set; }
            public decimal Total { get; set; }
            public Guid JobUid { get; set; }
            public Guid TaxUid { get; set; }
            public string RowVersion { get; set; }
        }

        #endregion
    }
}
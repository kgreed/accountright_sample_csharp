using System.Windows.Forms;
using MYOBApi.CSharp.Helpers;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace MYOBApi.CSharp.Forms
{
partial class InvoiceListForm 
{
  #region "Designer code"

        internal TabPage TabOpen;
        internal TabPage TabAll;
        internal DataGridView GridAllInvoices;
        internal TabPage TabClosed;
        internal TabPage TabCredit;
        internal DataGridView GridOpenInvoices;
        internal DataGridView GridCreditInvoices;
        internal DataGridView GridClosedInvoices;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewCardLinkColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridViewCardLinkColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn23;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn24;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn25;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn26;
        internal DataGridViewCardLinkColumn DataGridViewTextBoxColumn27;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn28;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn29;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn30;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn31;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn32;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn33;
        internal Button BtnNew;
        internal Panel Panel1;
        internal Button BtnPageRight;
        internal TextBox TextPage;
        internal Button BtnPageLeft;
        internal DataGridViewTextBoxColumn InvoiceType;
        internal DataGridViewTextBoxColumn Number;
        internal DataGridViewTextBoxColumn InvoiceDate;
        internal DataGridViewTextBoxColumn CustomerPurchaseOrderNumber;
        internal DataGridViewCardLinkColumn Customer;
        internal DataGridViewTextBoxColumn PromisedDate;
        internal DataGridViewTextBoxColumn BalanceDueAmount;
        internal DataGridViewTextBoxColumn Status;
        internal DataGridViewTextBoxColumn UID;
        internal DataGridViewTextBoxColumn URI;
        internal DataGridViewTextBoxColumn RowVersion;

        internal TabControl TabControl1;



        private void InitializeComponent()
        {
            var dataGridViewCellStyle13 = new DataGridViewCellStyle();
            var dataGridViewCellStyle14 = new DataGridViewCellStyle();
            var dataGridViewCellStyle15 = new DataGridViewCellStyle();
            var dataGridViewCellStyle16 = new DataGridViewCellStyle();
            var dataGridViewCellStyle17 = new DataGridViewCellStyle();
            var dataGridViewCellStyle18 = new DataGridViewCellStyle();
            var dataGridViewCellStyle19 = new DataGridViewCellStyle();
            var dataGridViewCellStyle20 = new DataGridViewCellStyle();
            var dataGridViewCellStyle21 = new DataGridViewCellStyle();
            var dataGridViewCellStyle22 = new DataGridViewCellStyle();
            var dataGridViewCellStyle23 = new DataGridViewCellStyle();
            var dataGridViewCellStyle24 = new DataGridViewCellStyle();
            TabControl1 = new TabControl();
            TabAll = new TabPage();
            GridAllInvoices = new DataGridView();
            InvoiceType = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            InvoiceDate = new DataGridViewTextBoxColumn();
            CustomerPurchaseOrderNumber = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewCardLinkColumn();
            PromisedDate = new DataGridViewTextBoxColumn();
            BalanceDueAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            UID = new DataGridViewTextBoxColumn();
            URI = new DataGridViewTextBoxColumn();
            RowVersion = new DataGridViewTextBoxColumn();
            TabOpen = new TabPage();
            GridOpenInvoices = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewCardLinkColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            TabCredit = new TabPage();
            GridCreditInvoices = new DataGridView();
            DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn16 = new DataGridViewCardLinkColumn();
            DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            TabClosed = new TabPage();
            GridClosedInvoices = new DataGridView();
            DataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn27 = new DataGridViewCardLinkColumn();
            DataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn29 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn30 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn31 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn32 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn33 = new DataGridViewTextBoxColumn();
            BtnNew = new Button();
            Panel1 = new Panel();
            BtnPageRight = new Button();
            TextPage = new TextBox();
            BtnPageLeft = new Button();
            TabControl1.SuspendLayout();
            TabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(GridAllInvoices)).BeginInit();
            TabOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(GridOpenInvoices)).BeginInit();
            TabCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(GridCreditInvoices)).BeginInit();
            TabClosed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(GridClosedInvoices)).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom) 
                                  | AnchorStyles.Left) 
                                 | AnchorStyles.Right;
            TabControl1.Controls.Add(TabAll);
            TabControl1.Controls.Add(TabOpen);
            TabControl1.Controls.Add(TabCredit);
            TabControl1.Controls.Add(TabClosed);
            TabControl1.Location = new System.Drawing.Point(12, 12);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new System.Drawing.Size(760, 509);
            TabControl1.TabIndex = 0;
            // 
            // TabAll
            // 
            TabAll.Controls.Add(GridAllInvoices);
            TabAll.Location = new System.Drawing.Point(4, 22);
            TabAll.Name = "TabAll";
            TabAll.Padding = new Padding(3);
            TabAll.Size = new System.Drawing.Size(752, 483);
            TabAll.TabIndex = 0;
            TabAll.Text = "All Invoices";
            TabAll.UseVisualStyleBackColor = true;
            // 
            // GridAllInvoices
            // 
            GridAllInvoices.AllowUserToAddRows = false;
            GridAllInvoices.AllowUserToDeleteRows = false;
            GridAllInvoices.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom) 
                                      | AnchorStyles.Left) 
                                     | AnchorStyles.Right;
            GridAllInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            GridAllInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridAllInvoices.Columns.AddRange(new DataGridViewColumn[] {
            InvoiceType,
            Number,
            InvoiceDate,
            CustomerPurchaseOrderNumber,
            Customer,
            PromisedDate,
            BalanceDueAmount,
            Status,
            UID,
            URI,
            RowVersion});
            GridAllInvoices.Location = new System.Drawing.Point(3, 3);
            GridAllInvoices.Name = "GridAllInvoices";
            GridAllInvoices.Size = new System.Drawing.Size(746, 477);
            GridAllInvoices.TabIndex = 0;
            GridAllInvoices.CellContentDoubleClick += new DataGridViewCellEventHandler(GridAllInvoicesCellContentDoubleClick);
            // 
            // InvoiceType
            // 
            InvoiceType.DataPropertyName = "InvoiceType";
            InvoiceType.HeaderText = "Type";
            InvoiceType.Name = "InvoiceType";
            InvoiceType.Width = 56;
            // 
            // Number
            // 
            Number.DataPropertyName = "Number";
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.Width = 69;
            // 
            // InvoiceDate
            // 
            InvoiceDate.DataPropertyName = "Date";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            InvoiceDate.DefaultCellStyle = dataGridViewCellStyle13;
            InvoiceDate.HeaderText = "Date";
            InvoiceDate.Name = "InvoiceDate";
            InvoiceDate.Width = 55;
            // 
            // CustomerPurchaseOrderNumber
            // 
            CustomerPurchaseOrderNumber.DataPropertyName = "CustomerPurchaseOrderNumber";
            CustomerPurchaseOrderNumber.HeaderText = "CustomerPurchaseOrderNumber";
            CustomerPurchaseOrderNumber.Name = "CustomerPurchaseOrderNumber";
            CustomerPurchaseOrderNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            CustomerPurchaseOrderNumber.Visible = false;
            CustomerPurchaseOrderNumber.Width = 165;
            // 
            // Customer
            // 
            Customer.DataPropertyName = "Customer";
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            Customer.Resizable = DataGridViewTriState.True;
            Customer.SortMode = DataGridViewColumnSortMode.Automatic;
            Customer.Width = 76;
            // 
            // PromisedDate
            // 
            PromisedDate.DataPropertyName = "PromisedDate";
            PromisedDate.HeaderText = "Promised Date";
            PromisedDate.Name = "PromisedDate";
            PromisedDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            PromisedDate.Visible = false;
            PromisedDate.Width = 82;
            // 
            // BalanceDueAmount
            // 
            BalanceDueAmount.DataPropertyName = "BalanceDueAmount";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            BalanceDueAmount.DefaultCellStyle = dataGridViewCellStyle14;
            BalanceDueAmount.HeaderText = "Balance Due";
            BalanceDueAmount.Name = "BalanceDueAmount";
            BalanceDueAmount.Width = 94;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Status.DefaultCellStyle = dataGridViewCellStyle15;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 62;
            // 
            // UID
            // 
            UID.DataPropertyName = "UID";
            UID.HeaderText = "UID";
            UID.Name = "UID";
            UID.SortMode = DataGridViewColumnSortMode.NotSortable;
            UID.Visible = false;
            UID.Width = 32;
            // 
            // URI
            // 
            URI.DataPropertyName = "URI";
            URI.HeaderText = "URI";
            URI.Name = "URI";
            URI.SortMode = DataGridViewColumnSortMode.NotSortable;
            URI.Visible = false;
            URI.Width = 32;
            // 
            // RowVersion
            // 
            RowVersion.DataPropertyName = "RowVersion";
            RowVersion.HeaderText = "RowVersion";
            RowVersion.Name = "RowVersion";
            RowVersion.SortMode = DataGridViewColumnSortMode.NotSortable;
            RowVersion.Visible = false;
            RowVersion.Width = 70;
            // 
            // TabOpen
            // 
            TabOpen.Controls.Add(GridOpenInvoices);
            TabOpen.Location = new System.Drawing.Point(4, 22);
            TabOpen.Name = "TabOpen";
            TabOpen.Padding = new Padding(3);
            TabOpen.Size = new System.Drawing.Size(752, 483);
            TabOpen.TabIndex = 1;
            TabOpen.Text = "Open Invoices";
            TabOpen.UseVisualStyleBackColor = true;
            // 
            // GridOpenInvoices
            // 
            GridOpenInvoices.AllowUserToAddRows = false;
            GridOpenInvoices.AllowUserToDeleteRows = false;
            GridOpenInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            GridOpenInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridOpenInvoices.Columns.AddRange(new DataGridViewColumn[] {
            DataGridViewTextBoxColumn1,
            DataGridViewTextBoxColumn2,
            DataGridViewTextBoxColumn3,
            DataGridViewTextBoxColumn4,
            DataGridViewTextBoxColumn5,
            DataGridViewTextBoxColumn6,
            DataGridViewTextBoxColumn7,
            DataGridViewTextBoxColumn8,
            DataGridViewTextBoxColumn9,
            DataGridViewTextBoxColumn10,
            DataGridViewTextBoxColumn11});
            GridOpenInvoices.Dock = DockStyle.Fill;
            GridOpenInvoices.Location = new System.Drawing.Point(3, 3);
            GridOpenInvoices.Name = "GridOpenInvoices";
            GridOpenInvoices.Size = new System.Drawing.Size(746, 477);
            GridOpenInvoices.TabIndex = 1;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceType";
            DataGridViewTextBoxColumn1.HeaderText = "Type";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.Width = 56;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "Number";
            DataGridViewTextBoxColumn2.HeaderText = "Number";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.Width = 69;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "Date";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle16;
            DataGridViewTextBoxColumn3.HeaderText = "Date";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.Width = 55;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "CustomerPurchaseOrderNumber";
            DataGridViewTextBoxColumn4.HeaderText = "CustomerPurchaseOrderNumber";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.Visible = false;
            DataGridViewTextBoxColumn4.Width = 184;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "Customer";
            DataGridViewTextBoxColumn5.HeaderText = "Customer";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.True;
            DataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Automatic;
            DataGridViewTextBoxColumn5.Width = 76;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "PromisedDate";
            DataGridViewTextBoxColumn6.HeaderText = "Promised Date";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            DataGridViewTextBoxColumn6.Visible = false;
            DataGridViewTextBoxColumn6.Width = 101;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "BalanceDueAmount";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            DataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle17;
            DataGridViewTextBoxColumn7.HeaderText = "Balance Due";
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.Width = 94;
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "Status";
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle18;
            DataGridViewTextBoxColumn8.HeaderText = "Status";
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            DataGridViewTextBoxColumn8.Width = 62;
            // 
            // DataGridViewTextBoxColumn9
            // 
            DataGridViewTextBoxColumn9.DataPropertyName = "UID";
            DataGridViewTextBoxColumn9.HeaderText = "UID";
            DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            DataGridViewTextBoxColumn9.Visible = false;
            DataGridViewTextBoxColumn9.Width = 51;
            // 
            // DataGridViewTextBoxColumn10
            // 
            DataGridViewTextBoxColumn10.DataPropertyName = "URI";
            DataGridViewTextBoxColumn10.HeaderText = "URI";
            DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            DataGridViewTextBoxColumn10.Visible = false;
            DataGridViewTextBoxColumn10.Width = 51;
            // 
            // DataGridViewTextBoxColumn11
            // 
            DataGridViewTextBoxColumn11.DataPropertyName = "RowVersion";
            DataGridViewTextBoxColumn11.HeaderText = "RowVersion";
            DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            DataGridViewTextBoxColumn11.Visible = false;
            DataGridViewTextBoxColumn11.Width = 89;
            // 
            // TabCredit
            // 
            TabCredit.Controls.Add(GridCreditInvoices);
            TabCredit.Location = new System.Drawing.Point(4, 22);
            TabCredit.Name = "TabCredit";
            TabCredit.Padding = new Padding(3);
            TabCredit.Size = new System.Drawing.Size(752, 483);
            TabCredit.TabIndex = 3;
            TabCredit.Text = "Returns & Credits";
            TabCredit.UseVisualStyleBackColor = true;
            // 
            // GridCreditInvoices
            // 
            GridCreditInvoices.AllowUserToAddRows = false;
            GridCreditInvoices.AllowUserToDeleteRows = false;
            GridCreditInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            GridCreditInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCreditInvoices.Columns.AddRange(new DataGridViewColumn[] {
            DataGridViewTextBoxColumn12,
            DataGridViewTextBoxColumn13,
            DataGridViewTextBoxColumn14,
            DataGridViewTextBoxColumn15,
            DataGridViewTextBoxColumn16,
            DataGridViewTextBoxColumn17,
            DataGridViewTextBoxColumn18,
            DataGridViewTextBoxColumn19,
            DataGridViewTextBoxColumn20,
            DataGridViewTextBoxColumn21,
            DataGridViewTextBoxColumn22});
            GridCreditInvoices.Dock = DockStyle.Fill;
            GridCreditInvoices.Location = new System.Drawing.Point(3, 3);
            GridCreditInvoices.Name = "GridCreditInvoices";
            GridCreditInvoices.Size = new System.Drawing.Size(746, 477);
            GridCreditInvoices.TabIndex = 2;
            // 
            // DataGridViewTextBoxColumn12
            // 
            DataGridViewTextBoxColumn12.DataPropertyName = "InvoiceType";
            DataGridViewTextBoxColumn12.HeaderText = "Type";
            DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            DataGridViewTextBoxColumn12.Width = 56;
            // 
            // DataGridViewTextBoxColumn13
            // 
            DataGridViewTextBoxColumn13.DataPropertyName = "Number";
            DataGridViewTextBoxColumn13.HeaderText = "Number";
            DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            DataGridViewTextBoxColumn13.Width = 69;
            // 
            // DataGridViewTextBoxColumn14
            // 
            DataGridViewTextBoxColumn14.DataPropertyName = "Date";
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            DataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle19;
            DataGridViewTextBoxColumn14.HeaderText = "Date";
            DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            DataGridViewTextBoxColumn14.Width = 55;
            // 
            // DataGridViewTextBoxColumn15
            // 
            DataGridViewTextBoxColumn15.DataPropertyName = "CustomerPurchaseOrderNumber";
            DataGridViewTextBoxColumn15.HeaderText = "CustomerPurchaseOrderNumber";
            DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            DataGridViewTextBoxColumn15.Visible = false;
            DataGridViewTextBoxColumn15.Width = 184;
            // 
            // DataGridViewTextBoxColumn16
            // 
            DataGridViewTextBoxColumn16.DataPropertyName = "Customer";
            DataGridViewTextBoxColumn16.HeaderText = "Customer";
            DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            DataGridViewTextBoxColumn16.ReadOnly = true;
            DataGridViewTextBoxColumn16.Resizable = DataGridViewTriState.True;
            DataGridViewTextBoxColumn16.SortMode = DataGridViewColumnSortMode.Automatic;
            DataGridViewTextBoxColumn16.Width = 76;
            // 
            // DataGridViewTextBoxColumn17
            // 
            DataGridViewTextBoxColumn17.DataPropertyName = "PromisedDate";
            DataGridViewTextBoxColumn17.HeaderText = "Promised Date";
            DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            DataGridViewTextBoxColumn17.Visible = false;
            DataGridViewTextBoxColumn17.Width = 101;
            // 
            // DataGridViewTextBoxColumn18
            // 
            DataGridViewTextBoxColumn18.DataPropertyName = "BalanceDueAmount";
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            DataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle20;
            DataGridViewTextBoxColumn18.HeaderText = "Balance Due";
            DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            DataGridViewTextBoxColumn18.Width = 94;
            // 
            // DataGridViewTextBoxColumn19
            // 
            DataGridViewTextBoxColumn19.DataPropertyName = "Status";
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle21;
            DataGridViewTextBoxColumn19.HeaderText = "Status";
            DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            DataGridViewTextBoxColumn19.Width = 62;
            // 
            // DataGridViewTextBoxColumn20
            // 
            DataGridViewTextBoxColumn20.DataPropertyName = "UID";
            DataGridViewTextBoxColumn20.HeaderText = "UID";
            DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            DataGridViewTextBoxColumn20.Visible = false;
            DataGridViewTextBoxColumn20.Width = 51;
            // 
            // DataGridViewTextBoxColumn21
            // 
            DataGridViewTextBoxColumn21.DataPropertyName = "URI";
            DataGridViewTextBoxColumn21.HeaderText = "URI";
            DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            DataGridViewTextBoxColumn21.Visible = false;
            DataGridViewTextBoxColumn21.Width = 51;
            // 
            // DataGridViewTextBoxColumn22
            // 
            DataGridViewTextBoxColumn22.DataPropertyName = "RowVersion";
            DataGridViewTextBoxColumn22.HeaderText = "RowVersion";
            DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            DataGridViewTextBoxColumn22.Visible = false;
            DataGridViewTextBoxColumn22.Width = 89;
            // 
            // TabClosed
            // 
            TabClosed.Controls.Add(GridClosedInvoices);
            TabClosed.Location = new System.Drawing.Point(4, 22);
            TabClosed.Name = "TabClosed";
            TabClosed.Size = new System.Drawing.Size(752, 483);
            TabClosed.TabIndex = 2;
            TabClosed.Text = "Closed Invoices";
            TabClosed.UseVisualStyleBackColor = true;
            // 
            // GridClosedInvoices
            // 
            GridClosedInvoices.AllowUserToAddRows = false;
            GridClosedInvoices.AllowUserToDeleteRows = false;
            GridClosedInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            GridClosedInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridClosedInvoices.Columns.AddRange(new DataGridViewColumn[] {
            DataGridViewTextBoxColumn23,
            DataGridViewTextBoxColumn24,
            DataGridViewTextBoxColumn25,
            DataGridViewTextBoxColumn26,
            DataGridViewTextBoxColumn27,
            DataGridViewTextBoxColumn28,
            DataGridViewTextBoxColumn29,
            DataGridViewTextBoxColumn30,
            DataGridViewTextBoxColumn31,
            DataGridViewTextBoxColumn32,
            DataGridViewTextBoxColumn33});
            GridClosedInvoices.Dock = DockStyle.Fill;
            GridClosedInvoices.Location = new System.Drawing.Point(0, 0);
            GridClosedInvoices.Name = "GridClosedInvoices";
            GridClosedInvoices.Size = new System.Drawing.Size(752, 483);
            GridClosedInvoices.TabIndex = 3;
            // 
            // DataGridViewTextBoxColumn23
            // 
            DataGridViewTextBoxColumn23.DataPropertyName = "InvoiceType";
            DataGridViewTextBoxColumn23.HeaderText = "Type";
            DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23";
            DataGridViewTextBoxColumn23.Width = 56;
            // 
            // DataGridViewTextBoxColumn24
            // 
            DataGridViewTextBoxColumn24.DataPropertyName = "Number";
            DataGridViewTextBoxColumn24.HeaderText = "Number";
            DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
            DataGridViewTextBoxColumn24.Width = 69;
            // 
            // DataGridViewTextBoxColumn25
            // 
            DataGridViewTextBoxColumn25.DataPropertyName = "Date";
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = null;
            DataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle22;
            DataGridViewTextBoxColumn25.HeaderText = "Date";
            DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
            DataGridViewTextBoxColumn25.Width = 55;
            // 
            // DataGridViewTextBoxColumn26
            // 
            DataGridViewTextBoxColumn26.DataPropertyName = "CustomerPurchaseOrderNumber";
            DataGridViewTextBoxColumn26.HeaderText = "CustomerPurchaseOrderNumber";
            DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26";
            DataGridViewTextBoxColumn26.Visible = false;
            DataGridViewTextBoxColumn26.Width = 184;
            // 
            // DataGridViewTextBoxColumn27
            // 
            DataGridViewTextBoxColumn27.DataPropertyName = "Customer";
            DataGridViewTextBoxColumn27.HeaderText = "Customer";
            DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27";
            DataGridViewTextBoxColumn27.ReadOnly = true;
            DataGridViewTextBoxColumn27.Resizable = DataGridViewTriState.True;
            DataGridViewTextBoxColumn27.SortMode = DataGridViewColumnSortMode.Automatic;
            DataGridViewTextBoxColumn27.Width = 76;
            // 
            // DataGridViewTextBoxColumn28
            // 
            DataGridViewTextBoxColumn28.DataPropertyName = "PromisedDate";
            DataGridViewTextBoxColumn28.HeaderText = "Promised Date";
            DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28";
            DataGridViewTextBoxColumn28.Visible = false;
            DataGridViewTextBoxColumn28.Width = 101;
            // 
            // DataGridViewTextBoxColumn29
            // 
            DataGridViewTextBoxColumn29.DataPropertyName = "BalanceDueAmount";
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "C2";
            dataGridViewCellStyle23.NullValue = null;
            DataGridViewTextBoxColumn29.DefaultCellStyle = dataGridViewCellStyle23;
            DataGridViewTextBoxColumn29.HeaderText = "Balance Due";
            DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29";
            DataGridViewTextBoxColumn29.Width = 94;
            // 
            // DataGridViewTextBoxColumn30
            // 
            DataGridViewTextBoxColumn30.DataPropertyName = "Status";
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewTextBoxColumn30.DefaultCellStyle = dataGridViewCellStyle24;
            DataGridViewTextBoxColumn30.HeaderText = "Status";
            DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30";
            DataGridViewTextBoxColumn30.Width = 62;
            // 
            // DataGridViewTextBoxColumn31
            // 
            DataGridViewTextBoxColumn31.DataPropertyName = "UID";
            DataGridViewTextBoxColumn31.HeaderText = "UID";
            DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31";
            DataGridViewTextBoxColumn31.Visible = false;
            DataGridViewTextBoxColumn31.Width = 51;
            // 
            // DataGridViewTextBoxColumn32
            // 
            DataGridViewTextBoxColumn32.DataPropertyName = "URI";
            DataGridViewTextBoxColumn32.HeaderText = "URI";
            DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32";
            DataGridViewTextBoxColumn32.Visible = false;
            DataGridViewTextBoxColumn32.Width = 51;
            // 
            // DataGridViewTextBoxColumn33
            // 
            DataGridViewTextBoxColumn33.DataPropertyName = "RowVersion";
            DataGridViewTextBoxColumn33.HeaderText = "RowVersion";
            DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33";
            DataGridViewTextBoxColumn33.Visible = false;
            DataGridViewTextBoxColumn33.Width = 89;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            BtnNew.Location = new System.Drawing.Point(616, 527);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new System.Drawing.Size(75, 23);
            BtnNew.TabIndex = 3;
            BtnNew.Text = "&New";
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += new System.EventHandler(BtnNewClick);
            // 
            // Panel1
            // 
            Panel1.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(BtnPageRight);
            Panel1.Controls.Add(TextPage);
            Panel1.Controls.Add(BtnPageLeft);
            Panel1.Location = new System.Drawing.Point(16, 528);
            Panel1.Name = "Panel1";
            Panel1.Size = new System.Drawing.Size(147, 22);
            Panel1.TabIndex = 4;
            // 
            // BtnPageRight
            // 
            BtnPageRight.Location = new System.Drawing.Point(115, 0);
            BtnPageRight.Margin = new Padding(0);
            BtnPageRight.Name = "BtnPageRight";
            BtnPageRight.Size = new System.Drawing.Size(30, 20);
            BtnPageRight.TabIndex = 2;
            BtnPageRight.Text = ">";
            BtnPageRight.UseVisualStyleBackColor = true;
            BtnPageRight.Click += new System.EventHandler(BtnPageRightClick);
            // 
            // TextPage
            // 
            TextPage.BackColor = System.Drawing.Color.White;
            TextPage.Location = new System.Drawing.Point(31, 0);
            TextPage.Name = "TextPage";
            TextPage.ReadOnly = true;
            TextPage.Size = new System.Drawing.Size(84, 20);
            TextPage.TabIndex = 1;
            TextPage.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnPageLeft
            // 
            BtnPageLeft.Location = new System.Drawing.Point(0, 0);
            BtnPageLeft.Margin = new Padding(0);
            BtnPageLeft.Name = "BtnPageLeft";
            BtnPageLeft.Size = new System.Drawing.Size(30, 20);
            BtnPageLeft.TabIndex = 0;
            BtnPageLeft.Text = "<";
            BtnPageLeft.UseVisualStyleBackColor = true;
            BtnPageLeft.Click += new System.EventHandler(BtnPageLeftClick);
            // 
            // InvoiceListForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            ClientSize = new System.Drawing.Size(784, 562);
            Controls.Add(Panel1);
            Controls.Add(BtnNew);
            Controls.Add(TabControl1);
            Name = "InvoiceListForm";
            Text = "Invoice List";
            Load += new System.EventHandler(InvoiceListFormLoad);
            Controls.SetChildIndex(TabControl1, 0);
            Controls.SetChildIndex(BtnNew, 0);
            Controls.SetChildIndex(Panel1, 0);
            TabControl1.ResumeLayout(false);
            TabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(GridAllInvoices)).EndInit();
            TabOpen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(GridOpenInvoices)).EndInit();
            TabCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(GridCreditInvoices)).EndInit();
            TabClosed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(GridClosedInvoices)).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }


        public InvoiceListForm()
        {
            Load += InvoiceListFormLoad;
            // This call is required by the designer.
            InitializeComponent();

        }

        #endregion
		}
		}
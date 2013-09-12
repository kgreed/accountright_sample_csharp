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
	partial class InvoiceForm 
	{
	
	      #region "Designer Code"

        internal Panel Panel1;
        internal ComboBox CmboCustomer;
        internal Label LblCustomer;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        private System.ComponentModel.IContainer components;
        internal Label LblAddress;
        internal TextBox TxtAddress;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer2;
        internal Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape2;
        internal Label V;
        internal TextBox TxtInvoiceNo;
        internal Label Label1;
        internal DateTimePicker DtDate;
        internal DataGridView GrdServiceLines;
        internal Button BtnRecord;
        internal BindingSource BsServiceInvoice;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn RowId;
        internal DataGridViewTextBoxColumn ColDescription;
        internal DataGridViewComboBoxColumn ColAccount;
        internal DataGridViewTextBoxColumn ColAmount;
        internal DataGridViewComboBoxColumn ColJob;
        internal DataGridViewComboBoxColumn ColTax;
        internal DataGridViewTextBoxColumn RowVersion;
        internal TextBox TextTotalAmount;
        internal Label LabelTotal;
        internal TextBox TextTax;
        internal Label LabelTax;
        internal TextBox TextSubtotal;
        internal Label LabelSubtotal;
        internal CheckBox ChkTaxInclusive;

        internal Label LblInvoice;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblInvoice = new System.Windows.Forms.Label();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ChkTaxInclusive = new System.Windows.Forms.CheckBox();
            this.BsServiceInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.TextTotalAmount = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.TextTax = new System.Windows.Forms.TextBox();
            this.LabelTax = new System.Windows.Forms.Label();
            this.TextSubtotal = new System.Windows.Forms.TextBox();
            this.LabelSubtotal = new System.Windows.Forms.Label();
            this.GrdServiceLines = new System.Windows.Forms.DataGridView();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJob = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColTax = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RowVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtDate = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtInvoiceNo = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.CmboCustomer = new System.Windows.Forms.ComboBox();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.ShapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.RectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsServiceInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdServiceLines)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInvoice
            // 
            this.LblInvoice.AutoSize = true;
            this.LblInvoice.BackColor = System.Drawing.Color.Transparent;
            this.LblInvoice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoice.Location = new System.Drawing.Point(15, 3);
            this.LblInvoice.Name = "LblInvoice";
            this.LblInvoice.Size = new System.Drawing.Size(153, 18);
            this.LblInvoice.TabIndex = 4;
            this.LblInvoice.Text = "Invoice - Service Layout";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.RectangleShape1});
            this.ShapeContainer1.Size = new System.Drawing.Size(784, 562);
            this.ShapeContainer1.TabIndex = 5;
            this.ShapeContainer1.TabStop = false;
            // 
            // RectangleShape1
            // 
            this.RectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleShape1.BackColor = System.Drawing.Color.White;
            this.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.RectangleShape1.Location = new System.Drawing.Point(10, 25);
            this.RectangleShape1.Name = "RectangleShape1";
            this.RectangleShape1.Size = new System.Drawing.Size(760, 490);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.Panel1.Controls.Add(this.ChkTaxInclusive);
            this.Panel1.Controls.Add(this.TextTotalAmount);
            this.Panel1.Controls.Add(this.LabelTotal);
            this.Panel1.Controls.Add(this.TextTax);
            this.Panel1.Controls.Add(this.LabelTax);
            this.Panel1.Controls.Add(this.TextSubtotal);
            this.Panel1.Controls.Add(this.LabelSubtotal);
            this.Panel1.Controls.Add(this.GrdServiceLines);
            this.Panel1.Controls.Add(this.DtDate);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.TxtInvoiceNo);
            this.Panel1.Controls.Add(this.V);
            this.Panel1.Controls.Add(this.LblAddress);
            this.Panel1.Controls.Add(this.TxtAddress);
            this.Panel1.Controls.Add(this.CmboCustomer);
            this.Panel1.Controls.Add(this.LblCustomer);
            this.Panel1.Controls.Add(this.ShapeContainer2);
            this.Panel1.Location = new System.Drawing.Point(14, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(752, 480);
            this.Panel1.TabIndex = 6;
            // 
            // ChkTaxInclusive
            // 
            this.ChkTaxInclusive.AutoSize = true;
            this.ChkTaxInclusive.Checked = true;
            this.ChkTaxInclusive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkTaxInclusive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BsServiceInvoice, "IsTaxInclusive", true));
            this.ChkTaxInclusive.Location = new System.Drawing.Point(550, 9);
            this.ChkTaxInclusive.Name = "ChkTaxInclusive";
            this.ChkTaxInclusive.Size = new System.Drawing.Size(89, 17);
            this.ChkTaxInclusive.TabIndex = 16;
            this.ChkTaxInclusive.Text = "Tax Inclusive";
            this.ChkTaxInclusive.UseVisualStyleBackColor = true;
            // 
            // BsServiceInvoice
            // 
            this.BsServiceInvoice.DataSource = typeof(MYOB.AccountRight.SDK.Contracts.Version2.Sale.ServiceInvoice);
            // 
            // TextTotalAmount
            // 
            this.TextTotalAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsServiceInvoice, "TotalAmount", true));
            this.TextTotalAmount.Enabled = false;
            this.TextTotalAmount.Location = new System.Drawing.Point(550, 432);
            this.TextTotalAmount.Name = "TextTotalAmount";
            this.TextTotalAmount.Size = new System.Drawing.Size(130, 20);
            this.TextTotalAmount.TabIndex = 15;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotal.Location = new System.Drawing.Point(471, 435);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(73, 13);
            this.LabelTotal.TabIndex = 14;
            this.LabelTotal.Text = "Total Amount:";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextTax
            // 
            this.TextTax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsServiceInvoice, "TotalTax", true));
            this.TextTax.Enabled = false;
            this.TextTax.Location = new System.Drawing.Point(550, 406);
            this.TextTax.Name = "TextTax";
            this.TextTax.Size = new System.Drawing.Size(130, 20);
            this.TextTax.TabIndex = 13;
            // 
            // LabelTax
            // 
            this.LabelTax.AutoSize = true;
            this.LabelTax.BackColor = System.Drawing.Color.Transparent;
            this.LabelTax.Location = new System.Drawing.Point(516, 409);
            this.LabelTax.Name = "LabelTax";
            this.LabelTax.Size = new System.Drawing.Size(28, 13);
            this.LabelTax.TabIndex = 12;
            this.LabelTax.Text = "Tax:";
            this.LabelTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextSubtotal
            // 
            this.TextSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsServiceInvoice, "Subtotal", true));
            this.TextSubtotal.Enabled = false;
            this.TextSubtotal.Location = new System.Drawing.Point(550, 380);
            this.TextSubtotal.Name = "TextSubtotal";
            this.TextSubtotal.Size = new System.Drawing.Size(130, 20);
            this.TextSubtotal.TabIndex = 11;
            // 
            // LabelSubtotal
            // 
            this.LabelSubtotal.AutoSize = true;
            this.LabelSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.LabelSubtotal.Location = new System.Drawing.Point(495, 383);
            this.LabelSubtotal.Name = "LabelSubtotal";
            this.LabelSubtotal.Size = new System.Drawing.Size(49, 13);
            this.LabelSubtotal.TabIndex = 10;
            this.LabelSubtotal.Text = "Subtotal:";
            this.LabelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GrdServiceLines
            // 
            this.GrdServiceLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdServiceLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdServiceLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowId,
            this.ColDescription,
            this.ColAccount,
            this.ColAmount,
            this.ColJob,
            this.ColTax,
            this.RowVersion});
            this.GrdServiceLines.Location = new System.Drawing.Point(19, 149);
            this.GrdServiceLines.Name = "GrdServiceLines";
            this.GrdServiceLines.Size = new System.Drawing.Size(713, 208);
            this.GrdServiceLines.TabIndex = 9;
            this.GrdServiceLines.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrdServiceLinesDataError);
            // 
            // RowId
            // 
            this.RowId.DataPropertyName = "RowId";
            this.RowId.HeaderText = "RowId";
            this.RowId.Name = "RowId";
            this.RowId.Visible = false;
            // 
            // ColDescription
            // 
            this.ColDescription.DataPropertyName = "Description";
            this.ColDescription.FillWeight = 200F;
            this.ColDescription.HeaderText = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.Width = 200;
            // 
            // ColAccount
            // 
            this.ColAccount.DataPropertyName = "AccountUID";
            this.ColAccount.HeaderText = "Account";
            this.ColAccount.Name = "ColAccount";
            this.ColAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAccount.Width = 150;
            // 
            // ColAmount
            // 
            this.ColAmount.DataPropertyName = "Total";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.ColAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColAmount.HeaderText = "Amount";
            this.ColAmount.Name = "ColAmount";
            // 
            // ColJob
            // 
            this.ColJob.DataPropertyName = "JobUID";
            this.ColJob.HeaderText = "Job";
            this.ColJob.Name = "ColJob";
            this.ColJob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColJob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColTax
            // 
            this.ColTax.DataPropertyName = "TaxUID";
            this.ColTax.HeaderText = "Tax";
            this.ColTax.Name = "ColTax";
            this.ColTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RowVersion
            // 
            this.RowVersion.DataPropertyName = "RowVersion";
            this.RowVersion.HeaderText = "RowVersion";
            this.RowVersion.Name = "RowVersion";
            this.RowVersion.Visible = false;
            // 
            // DtDate
            // 
            this.DtDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BsServiceInvoice, "Date", true));
            this.DtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDate.Location = new System.Drawing.Point(550, 84);
            this.DtDate.Name = "DtDate";
            this.DtDate.Size = new System.Drawing.Size(130, 20);
            this.DtDate.TabIndex = 8;
            this.DtDate.Value = new System.DateTime(2013, 8, 9, 23, 56, 56, 0);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(511, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Date:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtInvoiceNo
            // 
            this.TxtInvoiceNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsServiceInvoice, "Number", true));
            this.TxtInvoiceNo.Location = new System.Drawing.Point(550, 54);
            this.TxtInvoiceNo.Name = "TxtInvoiceNo";
            this.TxtInvoiceNo.Size = new System.Drawing.Size(130, 20);
            this.TxtInvoiceNo.TabIndex = 6;
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.BackColor = System.Drawing.Color.White;
            this.V.Location = new System.Drawing.Point(482, 57);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(62, 13);
            this.V.TabIndex = 5;
            this.V.Text = "Invoice No:";
            this.V.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.BackColor = System.Drawing.Color.White;
            this.LblAddress.Location = new System.Drawing.Point(133, 57);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(45, 13);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsServiceInvoice, "ShipToAddress", true));
            this.TxtAddress.Location = new System.Drawing.Point(188, 54);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress.Size = new System.Drawing.Size(249, 89);
            this.TxtAddress.TabIndex = 3;
            // 
            // CmboCustomer
            // 
            this.CmboCustomer.DisplayMember = "UID";
            this.CmboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboCustomer.FormattingEnabled = true;
            this.CmboCustomer.Location = new System.Drawing.Point(184, 6);
            this.CmboCustomer.Name = "CmboCustomer";
            this.CmboCustomer.Size = new System.Drawing.Size(254, 21);
            this.CmboCustomer.TabIndex = 1;
            this.CmboCustomer.ValueMember = "UID";
            this.CmboCustomer.SelectedIndexChanged += new System.EventHandler(this.CmboCustomerSelectedIndexChanged);
            this.CmboCustomer.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmboCustomerFormat);
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Location = new System.Drawing.Point(127, 9);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(51, 13);
            this.LblCustomer.TabIndex = 0;
            this.LblCustomer.Text = "Customer";
            // 
            // ShapeContainer2
            // 
            this.ShapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer2.Name = "ShapeContainer2";
            this.ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.RectangleShape2});
            this.ShapeContainer2.Size = new System.Drawing.Size(752, 480);
            this.ShapeContainer2.TabIndex = 2;
            this.ShapeContainer2.TabStop = false;
            // 
            // RectangleShape2
            // 
            this.RectangleShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleShape2.BackColor = System.Drawing.Color.White;
            this.RectangleShape2.FillColor = System.Drawing.Color.White;
            this.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.RectangleShape2.Location = new System.Drawing.Point(8, 40);
            this.RectangleShape2.Name = "RectangleShape2";
            this.RectangleShape2.Size = new System.Drawing.Size(735, 326);
            // 
            // BtnRecord
            // 
            this.BtnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecord.Location = new System.Drawing.Point(616, 527);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(75, 23);
            this.BtnRecord.TabIndex = 7;
            this.BtnRecord.Text = "Record";
            this.BtnRecord.UseVisualStyleBackColor = true;
            this.BtnRecord.Click += new System.EventHandler(this.BtnRecordClick);
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.DataGridViewTextBoxColumn1.FillWeight = 200F;
            this.DataGridViewTextBoxColumn1.HeaderText = "Description";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.Width = 200;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Total";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewTextBoxColumn2.FillWeight = 200F;
            this.DataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.Width = 200;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "RowVersion";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = "0.00";
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewTextBoxColumn3.HeaderText = "RowVersion";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Visible = false;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "RowVersion";
            this.DataGridViewTextBoxColumn4.HeaderText = "RowVersion";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LblInvoice);
            this.Controls.Add(this.ShapeContainer1);
            this.Name = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceFormLoad);
            this.Controls.SetChildIndex(this.ShapeContainer1, 0);
            this.Controls.SetChildIndex(this.LblInvoice, 0);
            this.Controls.SetChildIndex(this.Panel1, 0);
            this.Controls.SetChildIndex(this.BtnRecord, 0);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsServiceInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdServiceLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        public InvoiceForm()
        {
            Load += InvoiceFormLoad;
            // This call is required by the designer.
            InitializeComponent();
        }

        #endregion



	}
}
namespace MYOBApi.CSharp.Forms
{
partial class CompanyFilesForm 
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }


	//NOTE: The following procedure is required by the Windows Form Designer
	//It can be modified using the Windows Form Designer.  
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
            this.dgvCompanyFiles = new System.Windows.Forms.DataGridView();
            this.CF_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CF_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CF_ProductVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CF_LibraryPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picSpinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompanyFiles
            // 
            this.dgvCompanyFiles.AllowUserToAddRows = false;
            this.dgvCompanyFiles.AllowUserToDeleteRows = false;
            this.dgvCompanyFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompanyFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCompanyFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CF_Id,
            this.CF_Name,
            this.CF_ProductVersion,
            this.CF_LibraryPath});
            this.dgvCompanyFiles.Location = new System.Drawing.Point(13, 13);
            this.dgvCompanyFiles.MultiSelect = false;
            this.dgvCompanyFiles.Name = "dgvCompanyFiles";
            this.dgvCompanyFiles.ReadOnly = true;
            this.dgvCompanyFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanyFiles.Size = new System.Drawing.Size(938, 418);
            this.dgvCompanyFiles.TabIndex = 2;
            this.dgvCompanyFiles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompanyFilesCellContentDoubleClick);
            // 
            // CF_Id
            // 
            this.CF_Id.DataPropertyName = "Id";
            this.CF_Id.HeaderText = "Id";
            this.CF_Id.Name = "CF_Id";
            this.CF_Id.ReadOnly = true;
            this.CF_Id.Width = 41;
            // 
            // CF_Name
            // 
            this.CF_Name.DataPropertyName = "Name";
            this.CF_Name.HeaderText = "Name";
            this.CF_Name.Name = "CF_Name";
            this.CF_Name.ReadOnly = true;
            this.CF_Name.Width = 60;
            // 
            // CF_ProductVersion
            // 
            this.CF_ProductVersion.DataPropertyName = "ProductVersion";
            this.CF_ProductVersion.HeaderText = "ProductVersion";
            this.CF_ProductVersion.Name = "CF_ProductVersion";
            this.CF_ProductVersion.ReadOnly = true;
            this.CF_ProductVersion.Width = 104;
            // 
            // CF_LibraryPath
            // 
            this.CF_LibraryPath.DataPropertyName = "LibraryPath";
            this.CF_LibraryPath.HeaderText = "LibraryPath";
            this.CF_LibraryPath.Name = "CF_LibraryPath";
            this.CF_LibraryPath.ReadOnly = true;
            this.CF_LibraryPath.Visible = false;
            this.CF_LibraryPath.Width = 85;
            // 
            // picSpinner
            // 
            this.picSpinner.BackColor = System.Drawing.Color.White;
            this.picSpinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSpinner.Image = global::MYOBApi.CSharp.Properties.Resources.spinnerLarge;
            this.picSpinner.Location = new System.Drawing.Point(445, 207);
            this.picSpinner.Name = "picSpinner";
            this.picSpinner.Padding = new System.Windows.Forms.Padding(5);
            this.picSpinner.Size = new System.Drawing.Size(72, 72);
            this.picSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSpinner.TabIndex = 4;
            this.picSpinner.TabStop = false;
            // 
            // CompanyFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 486);
            this.Controls.Add(this.picSpinner);
            this.Controls.Add(this.dgvCompanyFiles);
            this.Name = "CompanyFilesForm";
            this.Text = "Company Files";
            this.Load += new System.EventHandler(this.CompanyFilesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
	internal System.Windows.Forms.DataGridView dgvCompanyFiles;
	internal System.Windows.Forms.DataGridViewTextBoxColumn CF_Id;
	internal System.Windows.Forms.DataGridViewTextBoxColumn CF_Name;
	internal System.Windows.Forms.DataGridViewTextBoxColumn CF_ProductVersion;
	internal System.Windows.Forms.DataGridViewTextBoxColumn CF_LibraryPath;

	internal System.Windows.Forms.PictureBox picSpinner;

}
}
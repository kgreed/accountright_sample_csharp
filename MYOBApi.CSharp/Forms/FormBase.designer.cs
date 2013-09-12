namespace MYOBApi.CSharp.Forms
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.picSpinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Location = new System.Drawing.Point(697, 527);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "&Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtnClick);
            // 
            // picSpinner
            // 
            this.picSpinner.BackColor = System.Drawing.Color.White;
            this.picSpinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSpinner.Image = global::MYOBApi.CSharp.Properties.Resources.spinnerLarge;
            this.picSpinner.Location = new System.Drawing.Point(362, 251);
            this.picSpinner.Name = "picSpinner";
            this.picSpinner.Padding = new System.Windows.Forms.Padding(5);
            this.picSpinner.Size = new System.Drawing.Size(72, 72);
            this.picSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSpinner.TabIndex = 3;
            this.picSpinner.TabStop = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.picSpinner);
            this.Controls.Add(this.CloseBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.Text = "FormBase";
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.Button CloseBtn;
        internal System.Windows.Forms.PictureBox picSpinner;

    }
}
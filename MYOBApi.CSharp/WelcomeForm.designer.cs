using System;

namespace MYOBApi.CSharp
{
partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lnkGetStarted = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.ErrorImage")));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(15, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(300, 131);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.Image = global::MYOBApi.CSharp.Properties.Resources.batman_reasonably_xsmall;
            this.PictureBox2.Location = new System.Drawing.Point(489, 266);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(58, 58);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 1;
            this.PictureBox2.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(11, 166);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(536, 29);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Welcome to the MYOBApi C# sample. ";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 195);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(537, 62);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "The purpose of this sample is to demonstrate using the AccountRight Live API via " +
    "the .NET SDK.  Click the link below to get started";
            // 
            // lnkGetStarted
            // 
            this.lnkGetStarted.AutoSize = true;
            this.lnkGetStarted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGetStarted.Location = new System.Drawing.Point(230, 257);
            this.lnkGetStarted.Name = "lnkGetStarted";
            this.lnkGetStarted.Size = new System.Drawing.Size(82, 19);
            this.lnkGetStarted.TabIndex = 4;
            this.lnkGetStarted.TabStop = true;
            this.lnkGetStarted.Text = "Get Started";
            this.lnkGetStarted.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkGetStartedLinkClicked);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(559, 336);
            this.Controls.Add(this.lnkGetStarted);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MYOB API C# Sample";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
	internal System.Windows.Forms.PictureBox PictureBox1;
	internal System.Windows.Forms.PictureBox PictureBox2;
	internal System.Windows.Forms.Label Label1;
	internal System.Windows.Forms.Label Label2;
	internal System.Windows.Forms.LinkLabel lnkGetStarted;
}
}
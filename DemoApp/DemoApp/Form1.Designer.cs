namespace DemoApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lcVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lcConnctionString = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(123, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 0;
            // 
            // lcVersion
            // 
            this.lcVersion.Location = new System.Drawing.Point(123, 12);
            this.lcVersion.Name = "lcVersion";
            this.lcVersion.Size = new System.Drawing.Size(0, 13);
            this.lcVersion.TabIndex = 1;
            this.lcVersion.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Version";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Enviornment";
            // 
            // lcConnctionString
            // 
            this.lcConnctionString.AutoSize = true;
            this.lcConnctionString.Location = new System.Drawing.Point(26, 110);
            this.lcConnctionString.Name = "lcConnctionString";
            this.lcConnctionString.Size = new System.Drawing.Size(35, 13);
            this.lcConnctionString.TabIndex = 4;
            this.lcConnctionString.Text = "label1";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Connection String";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 231);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lcConnctionString);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lcVersion);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lcVersion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label lcConnctionString;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}


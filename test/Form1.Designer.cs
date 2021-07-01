namespace test
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
            this.almGrid1 = new fgAlmViewer.almGrid();
            this.SuspendLayout();
            // 
            // almGrid1
            // 
            this.almGrid1.DataBase = "wwalmdb";
            this.almGrid1.Location = new System.Drawing.Point(12, 12);
            this.almGrid1.Name = "almGrid1";
            this.almGrid1.Node = "localhost";
            this.almGrid1.Password = "wwUser";
            this.almGrid1.Size = new System.Drawing.Size(906, 494);
            this.almGrid1.TabIndex = 0;
            this.almGrid1.User = "wwUser";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.almGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private fgAlmViewer.almGrid almGrid1;
    }
}


namespace HSK_BookStoreManagement
{
    partial class ThongKeNVTheoGT
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
            this.crpt_TKtheoGT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpt_TKtheoGT
            // 
            this.crpt_TKtheoGT.ActiveViewIndex = -1;
            this.crpt_TKtheoGT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpt_TKtheoGT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpt_TKtheoGT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpt_TKtheoGT.Location = new System.Drawing.Point(0, 0);
            this.crpt_TKtheoGT.Name = "crpt_TKtheoGT";
            this.crpt_TKtheoGT.Size = new System.Drawing.Size(800, 450);
            this.crpt_TKtheoGT.TabIndex = 0;
            // 
            // ThongKeNVTheoGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crpt_TKtheoGT);
            this.Name = "ThongKeNVTheoGT";
            this.Text = "ThongKeNVTheoGT";
            this.Load += new System.EventHandler(this.ThongKeNVTheoGT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpt_TKtheoGT;
    }
}
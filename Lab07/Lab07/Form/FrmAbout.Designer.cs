namespace Lab07
{
    partial class FrmAbout
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblInfo.Location = new System.Drawing.Point(30, 40);
            this.lblInfo.Size = new System.Drawing.Size(350, 100);
            this.lblInfo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblInfo);
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu phần mềm";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblInfo;
    }
}
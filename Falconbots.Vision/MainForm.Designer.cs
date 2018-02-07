namespace FalconBots.Vision
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void CrearVentana()
        {
            this.ImgOut = new System.Windows.Forms.PictureBox();
            this.Layout = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOut)).BeginInit();
            this.Layout.SuspendLayout();
            this.SuspendLayout();


            this.ImgOut.Location = new System.Drawing.Point(3, 3);
            this.ImgOut.Name = "ImgOut";
            this.ImgOut.Size = new System.Drawing.Size(320, 240);
            this.ImgOut.TabIndex = 1;
            this.ImgOut.TabStop = false;
           

            this.Layout.Controls.Add(this.ImgOut);
            this.Layout.Location = new System.Drawing.Point(12, 12);
            this.Layout.Name = "Layout";
            this.Layout.Size = new System.Drawing.Size(320, 240);
            this.Layout.TabIndex = 2;


            this.ClientSize = new System.Drawing.Size(676, 603);
            this.Controls.Add(this.Layout);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImgOut)).EndInit();
            this.Layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.PictureBox ImgOut;
        private new System.Windows.Forms.Panel Layout;
    }
}


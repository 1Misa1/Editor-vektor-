namespace VectorEditor_IT3B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxCanvas = new System.Windows.Forms.PictureBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCanvas
            // 
            this.pboxCanvas.BackColor = System.Drawing.Color.White;
            this.pboxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxCanvas.Location = new System.Drawing.Point(0, 0);
            this.pboxCanvas.Name = "pboxCanvas";
            this.pboxCanvas.Size = new System.Drawing.Size(994, 590);
            this.pboxCanvas.TabIndex = 0;
            this.pboxCanvas.TabStop = false;
            this.pboxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxCanvas_Paint);
            this.pboxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pboxCanvas_MouseClick);
            this.pboxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCanvas_MouseMove);
            // 
            // sfd
            // 
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 590);
            this.Controls.Add(this.pboxCanvas);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCanvas;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}


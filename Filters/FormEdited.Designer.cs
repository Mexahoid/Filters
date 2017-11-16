namespace Filters
{
    partial class FormEdited
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
            this.CtrlPnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CtrlPnlMain
            // 
            this.CtrlPnlMain.Location = new System.Drawing.Point(0, 0);
            this.CtrlPnlMain.Name = "CtrlPnlMain";
            this.CtrlPnlMain.Size = new System.Drawing.Size(559, 500);
            this.CtrlPnlMain.TabIndex = 1;
            // 
            // FormEdited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(559, 500);
            this.Controls.Add(this.CtrlPnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEdited";
            this.Text = "Измененное";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CtrlPnlMain;
    }
}
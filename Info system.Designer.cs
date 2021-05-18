namespace WindowsFormsApp2
{
    partial class Info_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_system));
            this.l = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.BackColor = System.Drawing.SystemColors.Control;
            this.l.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l.FormattingEnabled = true;
            this.l.Location = new System.Drawing.Point(12, 22);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(314, 312);
            this.l.TabIndex = 0;
            // 
            // Info_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 356);
            this.Controls.Add(this.l);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info_system";
            this.Text = "Informaçoes do Sistema";
            this.Load += new System.EventHandler(this.Info_system_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox l;
    }
}
namespace Calendar_Wforms
{
    partial class BlankUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_CelDay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_CelDay);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 41);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_CelDay
            // 
            this.Lbl_CelDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_CelDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_CelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CelDay.Location = new System.Drawing.Point(0, 0);
            this.Lbl_CelDay.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_CelDay.Name = "Lbl_CelDay";
            this.Lbl_CelDay.Size = new System.Drawing.Size(118, 41);
            this.Lbl_CelDay.TabIndex = 0;
            this.Lbl_CelDay.Text = "Past day";
            this.Lbl_CelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlankUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "BlankUserControl";
            this.Size = new System.Drawing.Size(118, 128);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_CelDay;
    }
}

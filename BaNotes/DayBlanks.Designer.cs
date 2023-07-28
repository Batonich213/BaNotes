namespace BaNotes
{
    partial class DayBlanks
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
            this.dayNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNum
            // 
            this.dayNum.BackColor = System.Drawing.Color.Transparent;
            this.dayNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayNum.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNum.Location = new System.Drawing.Point(0, 0);
            this.dayNum.Name = "dayNum";
            this.dayNum.Size = new System.Drawing.Size(170, 89);
            this.dayNum.TabIndex = 0;
            this.dayNum.Text = "01";
            this.dayNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayBlanks
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dayNum);
            this.Name = "DayBlanks";
            this.Size = new System.Drawing.Size(170, 89);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label dayNum;
    }
}

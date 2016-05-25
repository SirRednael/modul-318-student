namespace ÖvInfo
{
    partial class Stationboard
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
            this.liststationboard = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // liststationboard
            // 
            this.liststationboard.Location = new System.Drawing.Point(12, 12);
            this.liststationboard.Name = "liststationboard";
            this.liststationboard.Size = new System.Drawing.Size(428, 230);
            this.liststationboard.TabIndex = 0;
            this.liststationboard.UseCompatibleStateImageBehavior = false;
            this.liststationboard.View = System.Windows.Forms.View.Details;
            // 
            // Stationboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 254);
            this.Controls.Add(this.liststationboard);
            this.Name = "Stationboard";
            this.Text = "Stationboard";
            this.Load += new System.EventHandler(this.Stationboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView liststationboard;
    }
}
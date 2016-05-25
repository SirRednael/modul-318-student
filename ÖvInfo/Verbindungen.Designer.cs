namespace ÖvInfo
{
    partial class Verbindungen
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
            this.listConnection = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listConnection
            // 
            this.listConnection.AutoArrange = false;
            this.listConnection.Location = new System.Drawing.Point(4, 13);
            this.listConnection.Name = "listConnection";
            this.listConnection.Size = new System.Drawing.Size(750, 356);
            this.listConnection.TabIndex = 0;
            this.listConnection.UseCompatibleStateImageBehavior = false;
            this.listConnection.View = System.Windows.Forms.View.Details;
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 381);
            this.Controls.Add(this.listConnection);
            this.Name = "Verbindungen";
            this.Text = "Verbindungen";
            this.Load += new System.EventHandler(this.Verbindungen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listConnection;
    }
}
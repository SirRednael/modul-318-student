namespace ÖvInfo
{
    partial class Form1
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.selectionFrom = new System.Windows.Forms.ComboBox();
            this.selectionTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(12, 155);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(268, 39);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "Search Connection";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From:";
            // 
            // selectionFrom
            // 
            this.selectionFrom.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.selectionFrom.FormattingEnabled = true;
            this.selectionFrom.Location = new System.Drawing.Point(89, 12);
            this.selectionFrom.Name = "selectionFrom";
            this.selectionFrom.Size = new System.Drawing.Size(191, 21);
            this.selectionFrom.TabIndex = 5;
            this.selectionFrom.UseWaitCursor = true;
            this.selectionFrom.TextChanged += new System.EventHandler(this.selectionFrom_TextChanged);
            this.selectionFrom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectionFrom_MouseClick);
            // 
            // selectionTo
            // 
            this.selectionTo.FormattingEnabled = true;
            this.selectionTo.Location = new System.Drawing.Point(89, 50);
            this.selectionTo.Name = "selectionTo";
            this.selectionTo.Size = new System.Drawing.Size(191, 21);
            this.selectionTo.TabIndex = 6;
            this.selectionTo.UseWaitCursor = true;
            this.selectionTo.TextChanged += new System.EventHandler(this.selectionTo_TextChanged);
            this.selectionTo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectionTo_MouseClick);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 58);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 211);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.selectionTo);
            this.Controls.Add(this.selectionFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnsearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox selectionFrom;
        private System.Windows.Forms.ComboBox selectionTo;
        private System.Windows.Forms.Label lblTo;
    }
}


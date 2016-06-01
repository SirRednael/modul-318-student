namespace ÖvInfo
{
    partial class ConnectionSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionSearch));
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.selectionFrom = new System.Windows.Forms.ComboBox();
            this.selectionTo = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnStationBoardFrom = new System.Windows.Forms.Button();
            this.btnStationBoardTo = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.DateOfJourney = new System.Windows.Forms.DateTimePicker();
            this.timeOfJourney = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(12, 150);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(303, 39);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search Connection";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 16);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From:";
            // 
            // selectionFrom
            // 
            this.selectionFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectionFrom.FormattingEnabled = true;
            this.selectionFrom.Location = new System.Drawing.Point(89, 12);
            this.selectionFrom.Name = "selectionFrom";
            this.selectionFrom.Size = new System.Drawing.Size(175, 21);
            this.selectionFrom.TabIndex = 1;
            this.selectionFrom.TextUpdate += new System.EventHandler(this.selectionFrom_TextUpdate);
            this.selectionFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectionFrom_KeyDown);
            // 
            // selectionTo
            // 
            this.selectionTo.FormattingEnabled = true;
            this.selectionTo.Location = new System.Drawing.Point(89, 50);
            this.selectionTo.Name = "selectionTo";
            this.selectionTo.Size = new System.Drawing.Size(175, 21);
            this.selectionTo.TabIndex = 3;
            this.selectionTo.TextUpdate += new System.EventHandler(this.selectionTo_TextUpdate);
            this.selectionTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectionTo_KeyDown);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(9, 54);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // btnStationBoardFrom
            // 
            this.btnStationBoardFrom.Location = new System.Drawing.Point(270, 12);
            this.btnStationBoardFrom.Name = "btnStationBoardFrom";
            this.btnStationBoardFrom.Size = new System.Drawing.Size(45, 21);
            this.btnStationBoardFrom.TabIndex = 2;
            this.btnStationBoardFrom.Text = "Detail";
            this.btnStationBoardFrom.UseVisualStyleBackColor = true;
            this.btnStationBoardFrom.Click += new System.EventHandler(this.btnStationBoardFrom_Click);
            // 
            // btnStationBoardTo
            // 
            this.btnStationBoardTo.Location = new System.Drawing.Point(270, 50);
            this.btnStationBoardTo.Name = "btnStationBoardTo";
            this.btnStationBoardTo.Size = new System.Drawing.Size(45, 21);
            this.btnStationBoardTo.TabIndex = 4;
            this.btnStationBoardTo.Text = "Detail";
            this.btnStationBoardTo.UseVisualStyleBackColor = true;
            this.btnStationBoardTo.Click += new System.EventHandler(this.btnStationBoardTo_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(15, 128);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 10;
            // 
            // DateOfJourney
            // 
            this.DateOfJourney.CustomFormat = "yyyy-MM-dd";
            this.DateOfJourney.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfJourney.Location = new System.Drawing.Point(89, 100);
            this.DateOfJourney.Name = "DateOfJourney";
            this.DateOfJourney.Size = new System.Drawing.Size(80, 20);
            this.DateOfJourney.TabIndex = 5;
            // 
            // timeOfJourney
            // 
            this.timeOfJourney.CustomFormat = "HH:mm";
            this.timeOfJourney.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeOfJourney.Location = new System.Drawing.Point(175, 100);
            this.timeOfJourney.Name = "timeOfJourney";
            this.timeOfJourney.ShowUpDown = true;
            this.timeOfJourney.Size = new System.Drawing.Size(89, 20);
            this.timeOfJourney.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time of Departure:";
            // 
            // ConnectionSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeOfJourney);
            this.Controls.Add(this.DateOfJourney);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnStationBoardTo);
            this.Controls.Add(this.btnStationBoardFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.selectionTo);
            this.Controls.Add(this.selectionFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionSearch";
            this.Text = "ÖV Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox selectionFrom;
        private System.Windows.Forms.ComboBox selectionTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnStationBoardFrom;
        private System.Windows.Forms.Button btnStationBoardTo;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DateTimePicker DateOfJourney;
        private System.Windows.Forms.DateTimePicker timeOfJourney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


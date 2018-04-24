namespace CtoSQLConnections
{
    partial class resultTB
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
            this.salesOrdersDG = new System.Windows.Forms.DataGridView();
            this.customersCB = new System.Windows.Forms.ComboBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // salesOrdersDG
            // 
            this.salesOrdersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesOrdersDG.Location = new System.Drawing.Point(11, 50);
            this.salesOrdersDG.Name = "salesOrdersDG";
            this.salesOrdersDG.Size = new System.Drawing.Size(268, 193);
            this.salesOrdersDG.TabIndex = 0;
            this.salesOrdersDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesOrdersDG_CellContentClick);
            // 
            // customersCB
            // 
            this.customersCB.FormattingEnabled = true;
            this.customersCB.Location = new System.Drawing.Point(12, 12);
            this.customersCB.Name = "customersCB";
            this.customersCB.Size = new System.Drawing.Size(121, 21);
            this.customersCB.TabIndex = 1;
            this.customersCB.SelectedIndexChanged += new System.EventHandler(this.customersCB_SelectedIndexChanged_1);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Location = new System.Drawing.Point(164, 12);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(116, 23);
            this.ResultLabel.TabIndex = 2;
            // 
            // resultTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 259);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.customersCB);
            this.Controls.Add(this.salesOrdersDG);
            this.Name = "resultTB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.salesOrdersDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salesOrdersDG;
        private System.Windows.Forms.ComboBox customersCB;
        private System.Windows.Forms.Label ResultLabel;
    }
}


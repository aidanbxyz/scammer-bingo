namespace scammerBingo
{
    partial class scammerBingoMain
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
            this.mainSB = new System.Windows.Forms.Label();
            this.techSupportFormClick = new System.Windows.Forms.Button();
            this.wsTodayText = new System.Windows.Forms.Label();
            this.refundFormClick = new System.Windows.Forms.Button();
            this.mcs = new System.Windows.Forms.Label();
            this.startTechSupport = new System.Windows.Forms.Button();
            this.backTechSupport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainSB
            // 
            this.mainSB.AutoSize = true;
            this.mainSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSB.Location = new System.Drawing.Point(277, 9);
            this.mainSB.Name = "mainSB";
            this.mainSB.Size = new System.Drawing.Size(379, 55);
            this.mainSB.TabIndex = 0;
            this.mainSB.Text = "Scammer Bingo";
            // 
            // techSupportFormClick
            // 
            this.techSupportFormClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techSupportFormClick.Location = new System.Drawing.Point(12, 132);
            this.techSupportFormClick.Name = "techSupportFormClick";
            this.techSupportFormClick.Size = new System.Drawing.Size(909, 58);
            this.techSupportFormClick.TabIndex = 1;
            this.techSupportFormClick.Text = "Tech Support";
            this.techSupportFormClick.UseVisualStyleBackColor = true;
            this.techSupportFormClick.Click += new System.EventHandler(this.techSupportFormClick_Click);
            // 
            // wsTodayText
            // 
            this.wsTodayText.AutoSize = true;
            this.wsTodayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsTodayText.Location = new System.Drawing.Point(293, 73);
            this.wsTodayText.Name = "wsTodayText";
            this.wsTodayText.Size = new System.Drawing.Size(346, 20);
            this.wsTodayText.TabIndex = 2;
            this.wsTodayText.Text = "What scam are you having fun with today?";
            // 
            // refundFormClick
            // 
            this.refundFormClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundFormClick.Location = new System.Drawing.Point(12, 196);
            this.refundFormClick.Name = "refundFormClick";
            this.refundFormClick.Size = new System.Drawing.Size(909, 58);
            this.refundFormClick.TabIndex = 3;
            this.refundFormClick.Text = "Refunds";
            this.refundFormClick.UseVisualStyleBackColor = true;
            // 
            // mcs
            // 
            this.mcs.AutoSize = true;
            this.mcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcs.Location = new System.Drawing.Point(348, 366);
            this.mcs.Name = "mcs";
            this.mcs.Size = new System.Drawing.Size(236, 29);
            this.mcs.TabIndex = 4;
            this.mcs.Text = "More coming soon!";
            // 
            // startTechSupport
            // 
            this.startTechSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTechSupport.Location = new System.Drawing.Point(12, 132);
            this.startTechSupport.Name = "startTechSupport";
            this.startTechSupport.Size = new System.Drawing.Size(909, 58);
            this.startTechSupport.TabIndex = 5;
            this.startTechSupport.Text = "Start";
            this.startTechSupport.UseVisualStyleBackColor = true;
            this.startTechSupport.Visible = false;
            this.startTechSupport.Click += new System.EventHandler(this.startTechSupport_Click);
            // 
            // backTechSupport
            // 
            this.backTechSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backTechSupport.Location = new System.Drawing.Point(12, 196);
            this.backTechSupport.Name = "backTechSupport";
            this.backTechSupport.Size = new System.Drawing.Size(909, 58);
            this.backTechSupport.TabIndex = 6;
            this.backTechSupport.Text = "Back";
            this.backTechSupport.UseVisualStyleBackColor = true;
            this.backTechSupport.Visible = false;
            this.backTechSupport.Click += new System.EventHandler(this.backTechSupport_Click);
            // 
            // scammerBingoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.backTechSupport);
            this.Controls.Add(this.startTechSupport);
            this.Controls.Add(this.mcs);
            this.Controls.Add(this.refundFormClick);
            this.Controls.Add(this.wsTodayText);
            this.Controls.Add(this.techSupportFormClick);
            this.Controls.Add(this.mainSB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "scammerBingoMain";
            this.Text = "Scammer Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainSB;
        private System.Windows.Forms.Button techSupportFormClick;
        private System.Windows.Forms.Label wsTodayText;
        private System.Windows.Forms.Button refundFormClick;
        private System.Windows.Forms.Label mcs;
        private System.Windows.Forms.Button startTechSupport;
        private System.Windows.Forms.Button backTechSupport;
    }
}


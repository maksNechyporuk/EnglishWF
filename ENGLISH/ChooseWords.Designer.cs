namespace ENGLISH
{
    partial class ChooseWords
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
            this.ENGlabel = new System.Windows.Forms.Label();
            this.UKRlabel = new System.Windows.Forms.Label();
            this.LearnedB = new System.Windows.Forms.Button();
            this.LearnB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ENGlabel
            // 
            this.ENGlabel.AutoSize = true;
            this.ENGlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ENGlabel.Location = new System.Drawing.Point(24, 216);
            this.ENGlabel.Name = "ENGlabel";
            this.ENGlabel.Size = new System.Drawing.Size(115, 39);
            this.ENGlabel.TabIndex = 0;
            this.ENGlabel.Text = "label1";
            // 
            // UKRlabel
            // 
            this.UKRlabel.AutoSize = true;
            this.UKRlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UKRlabel.Location = new System.Drawing.Point(607, 216);
            this.UKRlabel.Name = "UKRlabel";
            this.UKRlabel.Size = new System.Drawing.Size(115, 39);
            this.UKRlabel.TabIndex = 1;
            this.UKRlabel.Text = "label1";
            // 
            // LearnedB
            // 
            this.LearnedB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearnedB.Location = new System.Drawing.Point(31, 409);
            this.LearnedB.Name = "LearnedB";
            this.LearnedB.Size = new System.Drawing.Size(118, 48);
            this.LearnedB.TabIndex = 2;
            this.LearnedB.Text = "Learned";
            this.LearnedB.UseVisualStyleBackColor = true;
            this.LearnedB.Click += new System.EventHandler(this.LearnedB_Click);
            // 
            // LearnB
            // 
            this.LearnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearnB.Location = new System.Drawing.Point(614, 409);
            this.LearnB.Name = "LearnB";
            this.LearnB.Size = new System.Drawing.Size(126, 48);
            this.LearnB.TabIndex = 3;
            this.LearnB.Text = "To learn";
            this.LearnB.UseVisualStyleBackColor = true;
            this.LearnB.Click += new System.EventHandler(this.LearnB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select 5 words";
            // 
            // ChooseWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LearnB);
            this.Controls.Add(this.LearnedB);
            this.Controls.Add(this.UKRlabel);
            this.Controls.Add(this.ENGlabel);
            this.Name = "ChooseWords";
            this.Text = "ChooseWords";
            this.Load += new System.EventHandler(this.ChooseWords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ENGlabel;
        private System.Windows.Forms.Label UKRlabel;
        private System.Windows.Forms.Button LearnedB;
        private System.Windows.Forms.Button LearnB;
        private System.Windows.Forms.Label label1;
    }
}
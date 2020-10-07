namespace ENGLISH
{
    partial class ShowDictionary
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
            this.FindButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WordGV = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engword_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukrword_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WordGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(855, 462);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(150, 58);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Visible = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(855, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.FindButton_Click);
            // 
            // WordGV
            // 
            this.WordGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WordGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Engword_,
            this.ukrword_});
            this.WordGV.Location = new System.Drawing.Point(12, 27);
            this.WordGV.Name = "WordGV";
            this.WordGV.ReadOnly = true;
            this.WordGV.Size = new System.Drawing.Size(727, 512);
            this.WordGV.TabIndex = 6;
            // 
            // number
            // 
            this.number.FillWeight = 60.9137F;
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // Engword_
            // 
            this.Engword_.FillWeight = 119.5432F;
            this.Engword_.HeaderText = "Engword";
            this.Engword_.Name = "Engword_";
            this.Engword_.ReadOnly = true;
            // 
            // ukrword_
            // 
            this.ukrword_.FillWeight = 119.5432F;
            this.ukrword_.HeaderText = "ukrword";
            this.ukrword_.Name = "ukrword_";
            this.ukrword_.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(852, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search for a word";
            // 
            // ShowDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordGV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FindButton);
            this.Name = "ShowDictionary";
            this.Text = "ShowDictionary";
            this.Load += new System.EventHandler(this.ShowDictionary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WordGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView WordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engword_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukrword_;
        private System.Windows.Forms.Label label1;
    }
}
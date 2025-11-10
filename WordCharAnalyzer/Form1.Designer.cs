namespace WordCharAnalyzer
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
            this.LblWordList = new System.Windows.Forms.Label();
            this.BtnListWords = new System.Windows.Forms.Button();
            this.BtnCharCount = new System.Windows.Forms.Button();
            this.BtnWordsCount = new System.Windows.Forms.Button();
            this.TxtCharToSearch = new System.Windows.Forms.TextBox();
            this.TxtStatement = new System.Windows.Forms.TextBox();
            this.LblWordCount = new System.Windows.Forms.Label();
            this.LblLetterCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblWordList
            // 
            this.LblWordList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblWordList.Location = new System.Drawing.Point(245, 215);
            this.LblWordList.Name = "LblWordList";
            this.LblWordList.Size = new System.Drawing.Size(108, 115);
            this.LblWordList.TabIndex = 14;
            // 
            // BtnListWords
            // 
            this.BtnListWords.Location = new System.Drawing.Point(245, 172);
            this.BtnListWords.Name = "BtnListWords";
            this.BtnListWords.Size = new System.Drawing.Size(108, 27);
            this.BtnListWords.TabIndex = 11;
            this.BtnListWords.Text = "لیست کلمات";
            this.BtnListWords.UseVisualStyleBackColor = true;
            this.BtnListWords.Click += new System.EventHandler(this.BtnListWords_Click);
            // 
            // BtnCharCount
            // 
            this.BtnCharCount.Location = new System.Drawing.Point(12, 174);
            this.BtnCharCount.Name = "BtnCharCount";
            this.BtnCharCount.Size = new System.Drawing.Size(78, 25);
            this.BtnCharCount.TabIndex = 10;
            this.BtnCharCount.Text = "تعداد حرف";
            this.BtnCharCount.UseVisualStyleBackColor = true;
            this.BtnCharCount.Click += new System.EventHandler(this.BtnCharCount_Click);
            // 
            // BtnWordsCount
            // 
            this.BtnWordsCount.Location = new System.Drawing.Point(130, 172);
            this.BtnWordsCount.Name = "BtnWordsCount";
            this.BtnWordsCount.Size = new System.Drawing.Size(78, 27);
            this.BtnWordsCount.TabIndex = 9;
            this.BtnWordsCount.Text = "تعداد کلمه";
            this.BtnWordsCount.UseVisualStyleBackColor = true;
            this.BtnWordsCount.Click += new System.EventHandler(this.BtnWordsCount_Click);
            // 
            // TxtCharToSearch
            // 
            this.TxtCharToSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCharToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtCharToSearch.Location = new System.Drawing.Point(56, 134);
            this.TxtCharToSearch.MaxLength = 1;
            this.TxtCharToSearch.Name = "TxtCharToSearch";
            this.TxtCharToSearch.Size = new System.Drawing.Size(261, 26);
            this.TxtCharToSearch.TabIndex = 8;
            // 
            // TxtStatement
            // 
            this.TxtStatement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtStatement.Location = new System.Drawing.Point(12, 12);
            this.TxtStatement.Multiline = true;
            this.TxtStatement.Name = "TxtStatement";
            this.TxtStatement.Size = new System.Drawing.Size(353, 116);
            this.TxtStatement.TabIndex = 7;
            // 
            // LblWordCount
            // 
            this.LblWordCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblWordCount.Location = new System.Drawing.Point(130, 215);
            this.LblWordCount.Name = "LblWordCount";
            this.LblWordCount.Size = new System.Drawing.Size(78, 25);
            this.LblWordCount.TabIndex = 15;
            // 
            // LblLetterCount
            // 
            this.LblLetterCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLetterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblLetterCount.Location = new System.Drawing.Point(12, 215);
            this.LblLetterCount.Name = "LblLetterCount";
            this.LblLetterCount.Size = new System.Drawing.Size(78, 25);
            this.LblLetterCount.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(38, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "سلام";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLetterCount);
            this.Controls.Add(this.LblWordCount);
            this.Controls.Add(this.LblWordList);
            this.Controls.Add(this.BtnListWords);
            this.Controls.Add(this.BtnCharCount);
            this.Controls.Add(this.BtnWordsCount);
            this.Controls.Add(this.TxtCharToSearch);
            this.Controls.Add(this.TxtStatement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblWordList;
        private System.Windows.Forms.Button BtnListWords;
        private System.Windows.Forms.Button BtnCharCount;
        private System.Windows.Forms.Button BtnWordsCount;
        private System.Windows.Forms.TextBox TxtCharToSearch;
        private System.Windows.Forms.TextBox TxtStatement;
        private System.Windows.Forms.Label LblWordCount;
        private System.Windows.Forms.Label LblLetterCount;
        private System.Windows.Forms.Label label1;
    }
}


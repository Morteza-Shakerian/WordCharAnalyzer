using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCharAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ValidateInput()
        {
            bool isTextEmpty = string.IsNullOrWhiteSpace(TxtStatement.Text);
            bool isCharEmpty = string.IsNullOrWhiteSpace(TxtCharToSearch.Text);
            if (isTextEmpty || isCharEmpty)
            {
                string message = " لطفا متن و حرف مورد نظر را وارد کنید";
                MessageBox.Show(message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public int CharCount(string text, string character)
        {
            int count = 0;
            foreach (char @char in text)
            {
                if (@char.ToString().Equals(character, StringComparison.OrdinalIgnoreCase))
                    count++;
            }
            return count;
        }

        public int WordCount(string text, string search)
        {
            var words = text.Split(' ');
            var count = 0;
            foreach (var word in words)
            {
                if (word.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
                    count++;
            }
            return count;
        }

        public string WordsList(string text, string search)
        {
            string result = "";
            var words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(search))
                {
                    result += words[i];
                    result += Environment.NewLine;
                }
            }
            return result;
        }

        private void BtnCharCount_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int count = CharCount(TxtStatement.Text, TxtCharToSearch.Text);
                LblLetterCount.Text = count.ToString();
            }
        }

        private void BtnWordsCount_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int count = WordCount(TxtStatement.Text, TxtCharToSearch.Text);
                LblWordCount.Text = count.ToString();
            }
        }

        private void BtnListWords_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string result = WordsList(TxtStatement.Text, TxtCharToSearch.Text);
                LblWordList.Text = result;
            }
        }
    }
}

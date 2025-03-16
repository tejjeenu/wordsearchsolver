using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wordsearch_breaker_app
{
    public partial class Form4 : Form
    {
        List<int> numarray = new List<int>();
        List<string> foundwords = new List<string>();
        int y = 0;
        int x = 0;
        string path2 = "";
        string[] dictionary = new string[0];
        string[,] p = new string[0, 0];
        const string indct = ">";

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                filelbl.Text = op.FileName;
            }
        }

        private void filelbl_Click(object sender, EventArgs e)
        {

        }

        private void addwordsbtn_Click(object sender, EventArgs e)
        {
            string word = wordlist.Text;
            string word1 = wordstxt.Text;

            try
            {
                int.Parse(word1);
            }
            catch
            {
                MessageBox.Show("error a number wasn't entered");
                return;
            }

            if (word == "null")
            {
                wordlist.Text = "";
            }
            numarray.Add(int.Parse(word1));
            wordlist.Text += Environment.NewLine + wordstxt.Text;
            wordstxt.Text = "";       
        }

        private void wordstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string word = wordlist.Text;
                string word1 = wordstxt.Text;

                try
                {
                    int.Parse(word1);
                }
                catch
                {
                    MessageBox.Show("error a number wasn't entered");
                    return;
                }

                if (word == "null")
                {
                    wordlist.Text = "";
                }
                numarray.Add(int.Parse(word1));
                wordlist.Text += Environment.NewLine + wordstxt.Text;
                wordstxt.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wordlist.Text = "";
            textBox1.Text = "";
            numarray = new List<int>();
            foundwords = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = filelbl.Text;
            string[] array = File.ReadAllLines(path);
            path2 = @"C:\Users\Tej\Desktop\app resources\dictionary.txt";
            dictionary = File.ReadAllLines(path2);
            y = array.Length;
            x = array[0].Length;
            p = new string[y, x];

            //this section of code puts all the code into an array
            int i = 0;
            foreach (string s in array)
            {
                int j = 0;
                Char[] arr = s.ToCharArray();
                foreach (char a in arr)
                {
                    p[i, j] = a.ToString();
                    j = j + 1;
                }
                i = i + 1;
            }

            foreach (int num in numarray)
            {
                if (num > x && num <= y)
                {
                    verticalsearchwithnum(num);
                }
                else if (num > y && num <= x)
                {
                    horizontalsearchwithnum(num);
                }
                else if (num <= x && num <= y)
                {
                    verticalsearchwithnum(num);
                    horizontalsearchwithnum(num);
                    uptodowndiagonalsearchwithnum(num);
                    downtoupdiagonalsearchwithnum(num);
                }
            }

            List<string> distinct = foundwords.Distinct().ToList();
            //Console.WriteLine("List after removing duplicate elements ...");
            foreach (string res in distinct)
            {
                textBox1.Text += res + Environment.NewLine;
            }
        }

        public void verticalsearchwithnum(int num)
        {
            bool verdict = false;
            int l = num;
            string attempt = "";
            int i = 0;
            int j = 0;
            int m = 0;
            int[] maxcoordinate = { y - 1, x - 1 };
            int[] currentcoordinate = { 0, 0 };

            while (Enumerable.SequenceEqual(currentcoordinate, maxcoordinate) == false)
            {
                if (j != 0)
                {
                    j = 0;
                    m = m + 1;
                }
                while (j < x)
                {
                    i = m;
                    verdict = false;
                    attempt = "";

                    while (attempt.Length < l)
                    {
                        attempt = attempt + p[i, j].Replace(indct, "");
                        i++;
                    }

                    foreach (string word in dictionary)
                    {
                        if (word.Length == l)
                        {
                            verdict = matchattempt(attempt, word, l);
                        }
                    }
                    j++;
                }
                currentcoordinate[0] = i - 1;
                currentcoordinate[1] = j - 1;
            }
        }

        public void horizontalsearchwithnum(int num)
        {
            bool verdict = false;
            int l = num;
            string attempt = "";
            int i = 0;
            int j = 0;
            int j2 = 0;
            int[] maxcoordinate = { y - 1, x - 1 };
            int[] currentcoordinate = { 0, 0 };

            while (Enumerable.SequenceEqual(currentcoordinate, maxcoordinate) == false)
            {
                if (j != 0)
                {
                    j = 0;
                    i = i + 1;
                }
                j2 = 0;
                while (j2 < x)
                {
                    verdict = false;
                    attempt = "";

                    j2 = j;
                    while (attempt.Length < l)
                    {
                        attempt = attempt + p[i, j2].Replace(indct, "");
                        j2++;
                    }

                    foreach (string word in dictionary)
                    {
                        if (word.Length == l)
                        {
                            verdict = matchattempt(attempt, word, l);
                        }
                    }

                    j++;
                }
                currentcoordinate[0] = i;
                currentcoordinate[1] = j2 - 1;
            }
        }

        public void uptodowndiagonalsearchwithnum(int num)
        {
            bool verdict = false;
            int l = num;
            string attempt = "";
            int i = 0;
            int j = 0;
            int j2 = 0;
            int i2 = 0;
            int[] maxcoordinate = { y - 1, x - 1 };
            int[] currentcoordinate = { 0, 0 };

            while (Enumerable.SequenceEqual(currentcoordinate, maxcoordinate) == false)
            {
                if (j != 0)
                {
                    j = 0;
                    i = i + 1;
                }
                j2 = 0;
                while (j2 < x)
                {
                    verdict = false;
                    attempt = "";

                    i2 = i;
                    j2 = j;
                    while (attempt.Length < l)
                    {
                        attempt = attempt + p[i2, j2].Replace(indct, "");
                        i2++;
                        j2++;
                    }

                    foreach (string word in dictionary)
                    {
                        if (word.Length == l)
                        {
                            verdict = matchattempt(attempt, word, l);
                        }
                    }
                    j++;
                }
                currentcoordinate[0] = i2 - 1;
                currentcoordinate[1] = j2 - 1;
            }
        }

        public void downtoupdiagonalsearchwithnum(int num)
        {
            bool verdict = false;
            int l = num;
            string attempt = "";
            int i = l - 1;
            int j = 0;
            int j2 = 0;
            int i2 = 0;
            int[] maxcoordinate = { y - 1, x - 1 };
            int[] currentcoordinate = { 0, 0 };

            while (Enumerable.SequenceEqual(currentcoordinate, maxcoordinate) == false)
            {
                if (j != 0)
                {
                    j = 0;
                    i = i + 1;
                }
                j2 = 0;
                while (j2 < x)
                {
                    verdict = false;
                    attempt = "";

                    i2 = i;
                    j2 = j;
                    while (attempt.Length < l)
                    {
                        attempt = attempt + p[i2, j2].Replace(indct, "");
                        i2--;
                        j2++;
                    }

                    foreach (string word in dictionary)
                    {
                        if (word.Length == l)
                        {
                            verdict = matchattempt(attempt, word, l);
                        }
                    }
                    j++;
                }
                currentcoordinate[0] = i;
                currentcoordinate[1] = j2 - 1;
            }
        }


        public bool matchattempt(string attempt, string word, int length)
        {
            Char[] chars = attempt.ToCharArray();
            bool verdict = false;
            string reversestring = "";

            Array.Reverse(chars);

            foreach (char c in chars)
            {
                reversestring = reversestring + c.ToString();
            }

            if (reversestring == word || attempt == word)
            {
                verdict = true;
                foundwords.Add(word);
            }
            return verdict;
        }

    }
}

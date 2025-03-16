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
    public partial class Form3 : Form
    {
        List<string> wordarray = new List<string>();
        int y = 0;
        int x = 0;
        string[,] p = new string[0, 0];
        const string indct = ">";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string path = filelbl.Text;
            string[] array = File.ReadAllLines(path);
            y = array.Length;
            x = array[0].Length;
            int k = 0;
            int l = 0;
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

            foreach (string word in wordarray)
            {
                if (word.Length > x && word.Length <= y)
                {
                    verticalsearch(word);
                }
                else if (word.Length > y && word.Length <= x)
                {
                    horizontalsearch(word);
                }
                else if (word.Length <= x && word.Length <= y)
                {
                    verticalsearch(word);
                    horizontalsearch(word);
                    uptodowndiagonalsearch(word);
                    downtoupdiagonalsearch(word);
                }
            }

            // this fills empty spaces
            while (k < y)
            {
                l = 0;
                while (l < x)
                {
                    if (p[k, l].Contains(indct) == false)
                    {
                        p[k, l] = p[k, l] + " ";
                    }
                    l++;
                }
                k++;
            }

            k = 0;
            l = 0;

            //this will print out the grid.
            while (k < y)
            {
                l = 0;
                while (l < x)
                {
                    textBox2.Text = textBox2.Text + p[k, l];
                    l++;
                }
                textBox2.Text = textBox2.Text + Environment.NewLine;
                k++;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                filelbl.Text = op.FileName;
            }
        }

        private void addwordsbtn_Click(object sender, EventArgs e)
        {
            string word = wordlist.Text;
            string word1 = wordstxt.Text;
            if (word == "null")
            {
                wordlist.Text = "";
            }
            if (word1.Length < 2)
            {
                MessageBox.Show("error a word wasn't entered");
            }
            else
            {
                wordarray.Add(wordstxt.Text);
                wordlist.Text += Environment.NewLine + wordstxt.Text;
                wordstxt.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wordlist.Text = "";
            wordarray = new List<string>();
        }

        public void verticalsearch(string word)
        {
            bool verdict = false;
            int l = word.Length;
            string attempt = "";
            int i = 0;
            int j = 0;
            int k = 0;
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

                    verdict = matchattempt(attempt, word, l);
                    if (verdict == true)
                    { //  this part of the the program works right
                        k = m;
                        while (k < i)
                        {
                            if (p[k, j].Contains(indct) == false)
                            {
                                p[k, j] = p[k, j] + indct;
                            }
                            k++;
                        }
                        i = k;
                    }
                    j++;
                }
                currentcoordinate[0] = i - 1;
                currentcoordinate[1] = j - 1;
            }
        }

        public void horizontalsearch(string word)
        {
            bool verdict = false;
            int l = word.Length;
            string attempt = "";
            int i = 0;
            int j = 0;
            int k = 0;
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

                    verdict = matchattempt(attempt, word, l);
                    if (verdict == true)
                    { //  this part of the the program works right
                        k = j;
                        while (k < j2)
                        {
                            if (p[i, k].Contains(indct) == false)
                            {
                                p[i, k] = p[i, k] + indct;
                            }
                            k++;
                        }
                    }
                    j++;
                }
                currentcoordinate[0] = i;
                currentcoordinate[1] = j2 - 1;
            }
        }

        public void uptodowndiagonalsearch(string word)
        {
            bool verdict = false;
            int l = word.Length;
            string attempt = "";
            int i = 0;
            int j = 0;
            int k = 0;
            int n = 0;
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

                    verdict = matchattempt(attempt, word, l);
                    if (verdict == true)
                    { //  this part of the the program works right
                        k = j;
                        n = i;
                        while (k < j2)
                        {
                            if (p[n, k].Contains(indct) == false)
                            {
                                p[n, k] = p[n, k] + indct;
                            }
                            k++;
                            n++;
                        }
                    }
                    j++;
                }
                currentcoordinate[0] = i2 - 1;
                currentcoordinate[1] = j2 - 1;
            }
        }

        public void downtoupdiagonalsearch(string word)
        {
            bool verdict = false;
            int l = word.Length;
            string attempt = "";
            int i = l - 1;
            int j = 0;
            int k = 0;
            int n = 0;
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

                    verdict = matchattempt(attempt, word, l);
                    if (verdict == true)
                    { //  this part of the the program works right
                        k = j;
                        n = i;
                        while (k < j2)
                        {
                            if (p[n, k].Contains(indct) == false)
                            {
                                p[n, k] = p[n, k] + indct;
                            }
                            k++;
                            n--;
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
            }
            return verdict;
        }

        private void wordstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string word = wordlist.Text;
                string word1 = wordstxt.Text;
                if (word == "null")
                {
                    wordlist.Text = "";
                }
                if (word1.Length < 2)
                {
                    MessageBox.Show("error a word wasn't entered");
                }
                else
                {
                    wordarray.Add(wordstxt.Text);
                    wordlist.Text += Environment.NewLine + wordstxt.Text;
                    wordstxt.Text = "";
                }
            }
        }
    }
}

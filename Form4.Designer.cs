
namespace wordsearch_breaker_app
{
    partial class Form4
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
            this.filelbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.wordstxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addwordsbtn = new System.Windows.Forms.Button();
            this.wordlist = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filelbl
            // 
            this.filelbl.AutoSize = true;
            this.filelbl.Location = new System.Drawing.Point(12, 61);
            this.filelbl.Name = "filelbl";
            this.filelbl.Size = new System.Drawing.Size(33, 20);
            this.filelbl.TabIndex = 8;
            this.filelbl.Text = "null";
            this.filelbl.Click += new System.EventHandler(this.filelbl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "enter word search: ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wordstxt
            // 
            this.wordstxt.Location = new System.Drawing.Point(16, 146);
            this.wordstxt.Name = "wordstxt";
            this.wordstxt.Size = new System.Drawing.Size(448, 26);
            this.wordstxt.TabIndex = 10;
            this.wordstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordstxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "enter lengths of text here:";
            // 
            // addwordsbtn
            // 
            this.addwordsbtn.Location = new System.Drawing.Point(16, 178);
            this.addwordsbtn.Name = "addwordsbtn";
            this.addwordsbtn.Size = new System.Drawing.Size(105, 40);
            this.addwordsbtn.TabIndex = 11;
            this.addwordsbtn.Text = "add lengths";
            this.addwordsbtn.UseVisualStyleBackColor = true;
            this.addwordsbtn.Click += new System.EventHandler(this.addwordsbtn_Click);
            // 
            // wordlist
            // 
            this.wordlist.AutoSize = true;
            this.wordlist.Location = new System.Drawing.Point(50, 240);
            this.wordlist.Name = "wordlist";
            this.wordlist.Size = new System.Drawing.Size(33, 20);
            this.wordlist.TabIndex = 12;
            this.wordlist.Text = "null";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "clear list";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "find words of this length";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 240);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(324, 306);
            this.textBox1.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 567);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.wordlist);
            this.Controls.Add(this.addwordsbtn);
            this.Controls.Add(this.wordstxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filelbl);
            this.Controls.Add(this.button2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filelbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox wordstxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addwordsbtn;
        private System.Windows.Forms.Label wordlist;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

namespace wordsearch_breaker_app
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.wordstxt = new System.Windows.Forms.TextBox();
            this.wordlist = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filelbl = new System.Windows.Forms.Label();
            this.addwordsbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter words here: ";
            // 
            // wordstxt
            // 
            this.wordstxt.Location = new System.Drawing.Point(44, 118);
            this.wordstxt.Name = "wordstxt";
            this.wordstxt.Size = new System.Drawing.Size(229, 26);
            this.wordstxt.TabIndex = 1;
            this.wordstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wordstxt_KeyDown);
            // 
            // wordlist
            // 
            this.wordlist.AutoSize = true;
            this.wordlist.Location = new System.Drawing.Point(40, 207);
            this.wordlist.Name = "wordlist";
            this.wordlist.Size = new System.Drawing.Size(33, 20);
            this.wordlist.TabIndex = 2;
            this.wordlist.Text = "null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "complete wordsearch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "enter word search: ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filelbl
            // 
            this.filelbl.AutoSize = true;
            this.filelbl.Location = new System.Drawing.Point(12, 61);
            this.filelbl.Name = "filelbl";
            this.filelbl.Size = new System.Drawing.Size(33, 20);
            this.filelbl.TabIndex = 6;
            this.filelbl.Text = "null";
            // 
            // addwordsbtn
            // 
            this.addwordsbtn.Location = new System.Drawing.Point(44, 151);
            this.addwordsbtn.Name = "addwordsbtn";
            this.addwordsbtn.Size = new System.Drawing.Size(105, 40);
            this.addwordsbtn.TabIndex = 7;
            this.addwordsbtn.Text = "add words";
            this.addwordsbtn.UseVisualStyleBackColor = true;
            this.addwordsbtn.Click += new System.EventHandler(this.addwordsbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "clear list";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(385, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 253);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 363);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addwordsbtn);
            this.Controls.Add(this.filelbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordlist);
            this.Controls.Add(this.wordstxt);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wordstxt;
        private System.Windows.Forms.Label wordlist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label filelbl;
        private System.Windows.Forms.Button addwordsbtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox textBox2;
    }
}


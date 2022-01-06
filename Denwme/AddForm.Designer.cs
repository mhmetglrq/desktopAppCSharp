namespace Denwme
{
    partial class AddForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxSynonmys = new System.Windows.Forms.GroupBox();
            this.tbxSynonmys = new System.Windows.Forms.TextBox();
            this.tbxSynonmysMeaning = new System.Windows.Forms.TextBox();
            this.gbxSentence = new System.Windows.Forms.GroupBox();
            this.tbxSentence = new System.Windows.Forms.TextBox();
            this.tbxSentenceMean = new System.Windows.Forms.TextBox();
            this.gbxWord = new System.Windows.Forms.GroupBox();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.tbxImg = new System.Windows.Forms.TextBox();
            this.tbxMean = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbxSynonmys.SuspendLayout();
            this.gbxSentence.SuspendLayout();
            this.gbxWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.gbxSynonmys);
            this.panel1.Controls.Add(this.gbxSentence);
            this.panel1.Controls.Add(this.gbxWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 380);
            this.panel1.TabIndex = 11;
            // 
            // gbxSynonmys
            // 
            this.gbxSynonmys.Controls.Add(this.tbxSynonmys);
            this.gbxSynonmys.Controls.Add(this.tbxSynonmysMeaning);
            this.gbxSynonmys.Location = new System.Drawing.Point(9, 215);
            this.gbxSynonmys.Name = "gbxSynonmys";
            this.gbxSynonmys.Size = new System.Drawing.Size(200, 100);
            this.gbxSynonmys.TabIndex = 12;
            this.gbxSynonmys.TabStop = false;
            this.gbxSynonmys.Text = "Synonmys";
            // 
            // tbxSynonmys
            // 
            this.tbxSynonmys.Location = new System.Drawing.Point(6, 19);
            this.tbxSynonmys.Name = "tbxSynonmys";
            this.tbxSynonmys.Size = new System.Drawing.Size(100, 20);
            this.tbxSynonmys.TabIndex = 6;
            // 
            // tbxSynonmysMeaning
            // 
            this.tbxSynonmysMeaning.Location = new System.Drawing.Point(94, 74);
            this.tbxSynonmysMeaning.Name = "tbxSynonmysMeaning";
            this.tbxSynonmysMeaning.Size = new System.Drawing.Size(100, 20);
            this.tbxSynonmysMeaning.TabIndex = 5;
            // 
            // gbxSentence
            // 
            this.gbxSentence.Controls.Add(this.tbxSentence);
            this.gbxSentence.Controls.Add(this.tbxSentenceMean);
            this.gbxSentence.Location = new System.Drawing.Point(124, 109);
            this.gbxSentence.Name = "gbxSentence";
            this.gbxSentence.Size = new System.Drawing.Size(200, 100);
            this.gbxSentence.TabIndex = 13;
            this.gbxSentence.TabStop = false;
            this.gbxSentence.Text = "Add Sentence";
            // 
            // tbxSentence
            // 
            this.tbxSentence.Location = new System.Drawing.Point(6, 19);
            this.tbxSentence.Name = "tbxSentence";
            this.tbxSentence.Size = new System.Drawing.Size(100, 20);
            this.tbxSentence.TabIndex = 3;
            // 
            // tbxSentenceMean
            // 
            this.tbxSentenceMean.Location = new System.Drawing.Point(94, 74);
            this.tbxSentenceMean.Name = "tbxSentenceMean";
            this.tbxSentenceMean.Size = new System.Drawing.Size(100, 20);
            this.tbxSentenceMean.TabIndex = 4;
            // 
            // gbxWord
            // 
            this.gbxWord.Controls.Add(this.tbxWord);
            this.gbxWord.Controls.Add(this.tbxImg);
            this.gbxWord.Controls.Add(this.tbxMean);
            this.gbxWord.Location = new System.Drawing.Point(3, 3);
            this.gbxWord.Name = "gbxWord";
            this.gbxWord.Size = new System.Drawing.Size(200, 100);
            this.gbxWord.TabIndex = 11;
            this.gbxWord.TabStop = false;
            this.gbxWord.Text = "Word";
            // 
            // tbxWord
            // 
            this.tbxWord.AccessibleName = "";
            this.tbxWord.Location = new System.Drawing.Point(6, 19);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(100, 20);
            this.tbxWord.TabIndex = 0;
            this.tbxWord.Tag = "";
            this.tbxWord.Text = "Kelime";
            this.tbxWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxImg
            // 
            this.tbxImg.Location = new System.Drawing.Point(94, 72);
            this.tbxImg.Name = "tbxImg";
            this.tbxImg.Size = new System.Drawing.Size(100, 20);
            this.tbxImg.TabIndex = 1;
            this.tbxImg.Text = "Resim Yolu";
            this.tbxImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxMean
            // 
            this.tbxMean.Location = new System.Drawing.Point(46, 46);
            this.tbxMean.Name = "tbxMean";
            this.tbxMean.Size = new System.Drawing.Size(100, 20);
            this.tbxMean.TabIndex = 2;
            this.tbxMean.Text = "Anlamı";
            this.tbxMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 55);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 404);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "Ekleme Formu";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panel1.ResumeLayout(false);
            this.gbxSynonmys.ResumeLayout(false);
            this.gbxSynonmys.PerformLayout();
            this.gbxSentence.ResumeLayout(false);
            this.gbxSentence.PerformLayout();
            this.gbxWord.ResumeLayout(false);
            this.gbxWord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbxSynonmys;
        private System.Windows.Forms.TextBox tbxSynonmys;
        private System.Windows.Forms.TextBox tbxSynonmysMeaning;
        private System.Windows.Forms.GroupBox gbxSentence;
        private System.Windows.Forms.TextBox tbxSentence;
        private System.Windows.Forms.TextBox tbxSentenceMean;
        private System.Windows.Forms.GroupBox gbxWord;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.TextBox tbxImg;
        private System.Windows.Forms.TextBox tbxMean;
        private System.Windows.Forms.Button btnAdd;
    }
}
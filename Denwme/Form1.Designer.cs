using System.Windows.Forms;

namespace Denwme
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgwWord = new System.Windows.Forms.DataGridView();
            this.dgwSentence = new System.Windows.Forms.DataGridView();
            this.dgwSynonmys = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.lblSentences = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblSynonyms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSentence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSynonmys)).BeginInit();
            this.SuspendLayout();
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "Word";
            // 
            // dgwWord
            // 
            this.dgwWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWord.Location = new System.Drawing.Point(12, 244);
            this.dgwWord.Name = "dgwWord";
            this.dgwWord.Size = new System.Drawing.Size(263, 165);
            this.dgwWord.TabIndex = 0;
            this.dgwWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // 
            // dgwSentence
            // 
            this.dgwSentence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwSentence.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSentence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSentence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSentence.Location = new System.Drawing.Point(12, 25);
            this.dgwSentence.Name = "dgwSentence";
            this.dgwSentence.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgwSentence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgwSentence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSentence.Size = new System.Drawing.Size(712, 185);
            this.dgwSentence.TabIndex = 1;
            // 
            // dgwSynonmys
            // 
            this.dgwSynonmys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSynonmys.Location = new System.Drawing.Point(301, 244);
            this.dgwSynonmys.Name = "dgwSynonmys";
            this.dgwSynonmys.Size = new System.Drawing.Size(263, 165);
            this.dgwSynonmys.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(608, 382);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Kelime Otomasyonu";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(630, 276);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 13);
            this.lblWord.TabIndex = 5;
            this.lblWord.Text = "Word";
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(599, 292);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(100, 20);
            this.tbxWord.TabIndex = 6;
            this.tbxWord.TextChanged += new System.EventHandler(this.tbxWord_TextChanged);
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Location = new System.Drawing.Point(12, 9);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(58, 13);
            this.lblSentences.TabIndex = 7;
            this.lblSentences.Text = "Sentences";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(12, 228);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(38, 13);
            this.lblWords.TabIndex = 8;
            this.lblWords.Text = "Words";
            // 
            // lblSynonyms
            // 
            this.lblSynonyms.AutoSize = true;
            this.lblSynonyms.Location = new System.Drawing.Point(298, 228);
            this.lblSynonyms.Name = "lblSynonyms";
            this.lblSynonyms.Size = new System.Drawing.Size(55, 13);
            this.lblSynonyms.TabIndex = 9;
            this.lblSynonyms.Text = "Synonyms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 433);
            this.Controls.Add(this.lblSynonyms);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.lblSentences);
            this.Controls.Add(this.tbxWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgwSynonmys);
            this.Controls.Add(this.dgwSentence);
            this.Controls.Add(this.dgwWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSentence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSynonmys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource wordBindingSource;
        private System.Windows.Forms.DataGridView dgwWord;
        private System.Windows.Forms.DataGridView dgwSentence;
        private System.Windows.Forms.DataGridView dgwSynonmys;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblSynonyms;
    }
}


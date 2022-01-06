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
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblField = new System.Windows.Forms.Label();
            this.lblUni = new System.Windows.Forms.Label();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(11, 244);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(100, 20);
            this.tbxWord.TabIndex = 0;
            this.tbxWord.Tag = "";
            this.tbxWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(91, 29);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Kelime Otomasyonu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.lblField);
            this.panel1.Controls.Add(this.lblUni);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.tbxWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 303);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Kelime Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(10, 270);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(101, 30);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Kelime Ara";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblField.Location = new System.Drawing.Point(3, 129);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(278, 37);
            this.lblField.TabIndex = 3;
            this.lblField.Text = "Yazılım Mühendisliği";
            // 
            // lblUni
            // 
            this.lblUni.AutoSize = true;
            this.lblUni.Location = new System.Drawing.Point(89, 85);
            this.lblUni.Name = "lblUni";
            this.lblUni.Size = new System.Drawing.Size(102, 13);
            this.lblUni.TabIndex = 2;
            this.lblUni.Text = "Samsun Universitesi";
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "Word";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(313, 327);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Kelime Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource wordBindingSource;
        private TextBox tbxWord;
        private Label lblDescription;
        private Panel panel1;
        private Button btnFind;
        private Label lblField;
        private Label lblUni;
        private Button btnAdd;
    }
}


using Denwme.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denwme
{
    public partial class Child : Form
    {

        public Child()
        {
            InitializeComponent();
        }

        private void Child_Load(object sender, EventArgs e)
        {

            lblWord.Text = WordModel._wordText;
            var word = new Word();
            using (var context = new AdalaContext())
            {
                    dgwSentence.DataSource = context.Sentences.Where(p => p.Word.Name.Contains(WordModel._wordText)).Select(p => new
                    {
                        p.Word.Name,
                        p.Sentences,
                        p.Meaning
                    }).ToList();
                    dgwSynonmys.DataSource = context.Synonmys.Where(p => p.Word.Name.Contains(WordModel._wordText)).Select(p => new
                    {
                        p.Word.Name,
                        p.SyName,
                        p.Meaning
                    }).ToList();
                 word = context.Words.Where(w => w.Name.Contains(WordModel._wordText)).FirstOrDefault();
            }
            WordModel._wordText = "";
            tbxWord.Text = word.Name;
            tbxMean.Text = word.Meaning;
            tbxImg.Text = word.ImgUrl;
            WordUpdateModel._word = word.Name;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context=new AdalaContext())
            {
                var word= context.Words.Where(w => w.Name.Contains(WordModel._wordText)).FirstOrDefault();
                var synonmys=context.Synonmys.Where(w => w.Word.Name.Contains(WordModel._wordText)).FirstOrDefault();
                var sentence = context.Sentences.Where(w => w.Word.Name.Contains(WordModel._wordText)).FirstOrDefault();
                context.Sentences.Remove(sentence);
                context.Words.Remove(word);
                context.Synonmys.Remove(synonmys);
                context.SaveChanges();
                MessageBox.Show("Başarıyla Silindi!");
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context=new AdalaContext())
            {
                
                string word=WordUpdateModel._word;
                var entityWord = context.Words.Where(w=>w.Name.Contains(word)).FirstOrDefault();
                entityWord.Name= tbxWord.Text;
                entityWord.Meaning= tbxMean.Text;
                entityWord.ImgUrl = tbxImg.Text;
                var entitySentence=context.Sentences.Where(s=>s.Word.Name.Contains(word)).FirstOrDefault();
                entitySentence.Sentences=tbxSentence.Text;
                entitySentence.Meaning=tbxSentenceMean.Text;
                var entitySynonmys = context.Synonmys.Where(s => s.Word.Name.Contains(word)).FirstOrDefault();
                entitySynonmys.SyName= tbxSynonmys.Text;
                entitySynonmys.Meaning=tbxSynonmysMeaning.Text;
                context.SaveChanges();
                MessageBox.Show("Başarıyla Güncellendi!");
            }
            
            this.Close();
        }
        private void dgwSentence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSentence.Text = dgwSentence.CurrentRow.Cells[1].Value.ToString();
            tbxSentenceMean.Text = dgwSentence.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgwSynonmys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSynonmys.Text = dgwSynonmys.CurrentRow.Cells[1].Value.ToString();
            tbxSynonmysMeaning.Text = dgwSynonmys.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

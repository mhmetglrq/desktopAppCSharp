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
    public partial class AddForm : Form
    {

       

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var word = new Word()
            {
                Name=tbxWord.Text,
                Meaning=tbxMean.Text,
                ImgUrl=tbxImg.Text
            };
            var synonmys = new Synonmys()
            {
                SyName = tbxSynonmys.Text,
                Meaning = tbxSynonmysMeaning.Text,
                Word = word
            };
            var sentence = new Sentence()
            {
                Sentences = tbxSentence.Text,
                Meaning = tbxSentenceMean.Text,
                Word = word
            };
            using (var context=new AdalaContext())
            {
                context.Words.Add(word);
                context.Sentences.Add(sentence);
                context.Synonmys.Add(synonmys);
                context.SaveChanges();
            }
            
            MessageBox.Show("Başarıyla Eklendi!");
            this.Close();
        }
    }
}

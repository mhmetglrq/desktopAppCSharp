using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denwme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context=new AdalaContext())
            {
                dgwWord.DataSource = context.Word.Select(p=> new 
                {
                    p.Name, 
                    p.Meaning
                }).ToList();
                dgwSentence.DataSource= context.Sentence.Select(p=> new 
                {
                    p.Sentences,
                    p.Meaning
                }).ToList();
                dgwSynonmys.DataSource = context.Synonmys.Select(p=> new
                {
                    p.Name,
                    p.Meaning
                }).ToList();
            }
        }

        private void tbxWord_TextChanged(object sender, EventArgs e)
        {
            using (var context=new AdalaContext())
            {
                dgwWord.DataSource = context.Word.Where(p => p.Name.Contains(tbxWord.Text)).Select(p=> new 
                {
                    p.Name,
                    p.Meaning
                }).ToList();
                dgwSentence.DataSource = context.Sentence.Include(p=>p.Word).Where(p => p.Word.Name.Contains(tbxWord.Text)).Select(p=> new 
                {
                    p.Sentences,
                    p.Meaning
                }).ToList();
                dgwSynonmys.DataSource = context.Synonmys.Include(p=>p.Word).Where(p=>p.Word.Name.Contains(tbxWord.Text)).Select(p=> new
                {
                    p.Name,
                    p.Meaning
                }).ToList();
              
            }
        }

        private void dgwWord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxWord.Text = dgwWord.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

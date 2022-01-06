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
            
        }


        private void btnFind_Click_1(object sender, EventArgs e)
        {
            using (var context=new AdalaContext())
            {
                var entity = context.Words.Where(w => w.Name.Contains(tbxWord.Text)).Select(w => w.Name).FirstOrDefault();
                if (entity!=null && entity.ToLower() == tbxWord.Text.ToLower())
                {
                    WordModel._wordText = entity.ToString();
                    var child = new Child();
                    child.Show();
                    tbxWord.Clear();
                }
                else if(entity==null)
                    MessageBox.Show("Girdiğiniz Kelime Bulunmamaktadır!");
                else 
                    MessageBox.Show("Lütfen Bir Kelime Giriniz!");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm=new AddForm();
            addForm.Show(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pessoas
{
    public partial class Form1 : Form
    {   
        private List<Person> persons = new List<Person>();
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = persons;
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {            
            Form2 telaDeCadastro = new Form2(salvarPessoa);
            telaDeCadastro.ShowDialog();
            
        }

        private void salvarPessoa (Person pessoa)
        {
                      
            persons.Add(pessoa);
            BindingSource fonte = new BindingSource();
            fonte.DataSource = persons;
            dataGridView1.DataSource = fonte;
            
        }

        
    }
}

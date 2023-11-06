using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pessoas
{
    public partial class Form2 : Form
    {
        Action<Person> salvarPessoa;
        
        public Form2(Action<Person> cadastraPessoa)
        {
            InitializeComponent();
            this.salvarPessoa = cadastraPessoa;          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxName.Text;
            int idade = Convert.ToInt32(numericUpDownAge.Value);

            Person pessoa = new Person(nome, idade);

            this.salvarPessoa(pessoa);
            
            this.Close();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

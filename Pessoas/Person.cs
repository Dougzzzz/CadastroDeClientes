using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    public class Person
    {
        public string Nome { get; set; }
        public int Idade { get; set;}

        public Person(string nome, int idade) 
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}

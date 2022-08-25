using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClasses
{
    internal class Pessoas
    {
        String Nome, Cpf, DataNascimento;


        public Pessoas()
        {
           
        }
        public void setNome()
        {
            Console.WriteLine("Insira seu nome: ");
            this.Nome = Console.ReadLine();
        }

        public void setData()
        {
            Console.WriteLine("\nInsira sua data de nascimento: ");
            this.DataNascimento = Console.ReadLine();
        }

        public void setDocumento()
        {
            Console.Write("\nInforme seu CPF: ");
            this.Cpf = (Console.ReadLine());
        }

        public void getNome()
        {
            Console.WriteLine("O nome informado foi: " + this.Nome);
        }

        public void getData()
        {
            Console.WriteLine("A data de nascimento informada por " + this.Nome + " informada foi: " + this.DataNascimento);
        }

        public void getDocumento()
        {
            Console.WriteLine("o cpf de" + this.Nome + " é correspondete a " + this.Cpf);
        }

        public void RealizarCadastro()
        {
            setNome();
            setData();
            setDocumento();
        }

        public override String ToString()
        {
            return "\nNome: " + Nome + "Data de Nascimento: " + DataNascimento + "CPF: " + Cpf;
        }
    }
}
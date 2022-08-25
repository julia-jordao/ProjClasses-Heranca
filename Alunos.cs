using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClasses
{
    internal class Alunos : Pessoas
    {
        String DataMatricula;
        String Registro;

        public Alunos()
        {

        }

        public void setRegistro()
        {
            Console.WriteLine("Insira seu registro (formato: XXXXX-X): ");
            Registro = Console.ReadLine();
        }

        public void setDataMatricula()
        {
            Console.WriteLine("Insira sua data de matrícula (formato: dd/mm/aaaa): ");
            DataMatricula = Console.ReadLine();
        }

        public void setMatricula()
        {
            setRegistro();
            setDataMatricula();
        }

        public override string ToString()
        {
            return base.ToString() + "Registro: "+Registro+"\nData da matrícula: "+DataMatricula;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjClasses
{
    internal class Funcionarios : Pessoas
    {
        String NumeroPis, Setor;
        float salario;
        public Funcionarios()
        {

        }
        public void setNumeroPis()
        {
            Console.WriteLine("Insira seu número PIS: ");
            NumeroPis = Console.ReadLine();
        }
        public void setSalario()
        {
            Console.WriteLine("Insira seu salário:");
            salario = float.Parse(Console.ReadLine());
        }
        public void setSetor()
        {
            Console.WriteLine("Insira o setor em que trabalha: ");
            Setor = Console.ReadLine();
        }
        public void setRegistroFuncionario()
        {
            setNumeroPis();
            setSalario();
            setSetor();
        }
        public override String ToString()
        {
            return base.ToString() + "PIS: " + NumeroPis + "\nSalário: " + salario + "\nSetor: " + Setor;
        }
    }
}

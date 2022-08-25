using System;

namespace ProjClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CADASTRO PESSOA
            Pessoas pessoas = new Pessoas();
            pessoas.RealizarCadastro();
            Console.WriteLine(pessoas.ToString());

            //CADASTRO ALUNO -> HERANÇA
            Alunos alunos = new Alunos();
            alunos.RealizarCadastro();
            alunos.setMatricula();
            Console.WriteLine(alunos.ToString());

            // CADASTRO FUNCIONARIO -> HERANÇA
            Funcionarios funcionario = new Funcionarios();
            funcionario.RealizarCadastro();
            funcionario.setRegistroFuncionario();
            Console.WriteLine(funcionario.ToString());
        }
    }
}

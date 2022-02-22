using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            //carlos.Nome = "Carlos";

            //carlos.AumentarSalario();
            //Console.WriteLine("Novo salario do Carlos: " + carlos.Salario);

            //Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //gerenciador.Registrar(carlos);

            //Diretor roberta = new Diretor("454.658.148-3");
            //roberta.Nome = "Roberta";

            //Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //Funcionario robertaTeste = roberta;

            //roberta.AumentarSalario();
            //Console.WriteLine("Novo salario de Roberta: " + roberta.Salario);

            //Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            //Console.WriteLine("Bonificação de uma referência de Funcionário: " + robertaTeste.GetBonificacao());

            //gerenciador.Registrar(roberta);

            //Console.WriteLine(carlos.Nome);
            //Console.WriteLine(carlos.GetBonificacao());

            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine(roberta.GetBonificacao());

            //Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao()); ;
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }
    }
}

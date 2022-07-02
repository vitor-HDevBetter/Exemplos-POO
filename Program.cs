using BancoHDevBetterApp.Enums;

namespace BancoHDevBetterApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem vindo ao banco HDevBetter, favor preencha os seguintes campos: ");

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Selecione o tipo de conta: 1 - Cliente, 2 - Atendente, 3 - Gerente");
            var tipoConta = Console.ReadLine();

            switch (tipoConta)
            {
                case "1":
                    CriarCliente(nome); break;
                case "2":
                    CriarAtendente(nome); break;
                case "3":
                    CriarGerente(nome); break;

                default: throw new ArgumentException("Ocorreu um erro interno");
            }
        }

        static string MenuOperacao()
        {
            Console.WriteLine(" ");
            Console.WriteLine("O que deseja fazer ? ");

            Console.WriteLine("1 - Ver saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Realizar emprestimo");
            Console.WriteLine("5 - Ver informações da minha conta");

            var acao = Console.ReadLine();

            switch (acao)
            {
                case "1":
                    return "Ver Saldo"; break;
                case "2":
                    return "Depositar"; break;
                case "3":
                    return "Sacar"; break;
                case "4":
                    return "RealizarEmprestimo"; break;
                case "5":
                    return "Infos"; break;

                default: throw new ArgumentException("Ocorreu um erro interno");
            }
        }

        static void CriarCliente(string nome)
        {
            Cliente cliente = new Cliente(TipoConta.Cliente);
            cliente.Nome = nome;

            ProcessarCliente(cliente);
        }

        static void ProcessarCliente(Cliente cliente)
        {
            var retorno = MenuOperacao();

            double resultado = 0;

            if (retorno == "Ver Saldo")
            {
                Console.WriteLine(" ");

                resultado = cliente.VerSaldo();
                Console.WriteLine($"Seu saldo é de R$ {resultado}");
            }
            else if (retorno == "Depositar")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quanto deseja depositar ?");
                var valor = double.Parse(Console.ReadLine());

                cliente.Depositar(valor);

                Console.WriteLine($"Valor depositado com sucesso");
            }
            else if (retorno == "Sacar")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quanto deseja sacar ?");
                var valor = double.Parse(Console.ReadLine());

                cliente.Sacar(valor);

                Console.WriteLine($"Valor sacado com sucesso");
                Console.WriteLine($"Saldo apos o saque: R$ {cliente.VerSaldo()}");
            }
            else if (retorno == "RealizarEmprestimo")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Qual o valor que deseja do emprestimo ?");
                var valor = double.Parse(Console.ReadLine());

                cliente.RealizarEmprestimo(valor);

                Console.WriteLine($"Emprestimo realizado com sucesso");
                Console.WriteLine($"Juros a ser pago: {cliente.CalcularJurosEmprestimo()} ");
            }
            else
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Id: {cliente.Id}, Nome: {cliente.Nome}, Saldo: {cliente.Saldo}, Valor Emprestimo: {cliente.ValorEmprestimo}, Taxa de Juros Emprestimo: {cliente.JurosEmprestimo}");
            }

            Console.WriteLine(" ");
            ProcessarCliente(cliente);
        }

        static void CriarAtendente(string nome)
        {
            Atendente atendente = new Atendente(TipoConta.Atendente);
            atendente.Nome = nome;

            ProcessarAtendente(atendente);
        }

        static void ProcessarAtendente(Atendente atendente)
        {
            var retorno = MenuOperacao();

            double resultado = 0;

            if (retorno == "Ver Saldo")
            {
                Console.WriteLine(" ");

                resultado = atendente.VerSaldo();
                Console.WriteLine($"Seu saldo é de R$ {resultado}");
            }
            else if (retorno == "Depositar")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quanto deseja depositar ?");
                var valor = double.Parse(Console.ReadLine());

                atendente.Depositar(valor);

                Console.WriteLine($"Valor depositado com sucesso");
            }
            else if (retorno == "Sacar")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quanto deseja sacar ?");
                var valor = double.Parse(Console.ReadLine());

                atendente.Sacar(valor);

                Console.WriteLine($"Valor sacado com sucesso");
                Console.WriteLine($"Saldo apos o saque: R$ {atendente.VerSaldo()}");
            }
            else if (retorno == "RealizarEmprestimo")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quantas aberturas de conta foi feita no mes ?");
                var qtd = int.Parse(Console.ReadLine());

                atendente.QtdAberturaDeContas = qtd;

                Console.WriteLine($"Qual o valor que deseja do emprestimo ?");
                var valor = double.Parse(Console.ReadLine());

                atendente.RealizarEmprestimo(valor);

                Console.WriteLine($"Emprestimo realizado com sucesso");
                Console.WriteLine($"Juros a ser pago: {atendente.CalcularJurosEmprestimo()} ");
            }
            else
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Id: {atendente.Id}, Nome: {atendente.Nome}, Saldo: {atendente.Saldo}, Valor Emprestimo: {atendente.ValorEmprestimo}, Taxa de Juros Emprestimo: {atendente.JurosEmprestimo}");
            }

            Console.WriteLine(" ");
            ProcessarAtendente(atendente);
        }

        static void CriarGerente(string nome)
        {
            Gerente gerente = new Gerente(TipoConta.Gerente);
            gerente.Nome = nome;

            ProcessarGerente(gerente);
        }

        static void ProcessarGerente(Gerente gerente)
        {
            var retorno = MenuOperacao();

            double resultado = 0;

            if (retorno == "Ver Saldo")
            {
                Console.WriteLine(" ");

                resultado = gerente.VerSaldo();
                Console.WriteLine($"Seu saldo é de R$ {resultado}");
            }
            else if (retorno == "Depositar")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quanto deseja depositar ?");
                var valor = double.Parse(Console.ReadLine());

                gerente.Depositar(valor);

                Console.WriteLine($"Valor depositado com sucesso");
            }
            else if (retorno == "Sacar")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quanto deseja sacar ?");
                var valor = double.Parse(Console.ReadLine());

                gerente.Sacar(valor);

                Console.WriteLine($"Valor sacado com sucesso");
                Console.WriteLine($"Saldo apos o saque: R$ {gerente.VerSaldo()}");
            }
            else if (retorno == "RealizarEmprestimo")
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Quantas consultorias foram realizadas esse mes ?");
                var qtd = int.Parse(Console.ReadLine());

                gerente.QtdConsultorias = qtd;

                Console.WriteLine($"Qual o valor que deseja do emprestimo ?");
                var valor = double.Parse(Console.ReadLine());

                gerente.RealizarEmprestimo(valor);

                Console.WriteLine($"Emprestimo realizado com sucesso");
                Console.WriteLine($"Juros a ser pago: {gerente.CalcularJurosEmprestimo()} ");
            }
            else
            {
                Console.WriteLine(" ");

                Console.WriteLine($"Id: {gerente.Id}, Nome: {gerente.Nome}, Saldo: {gerente.Saldo}, Valor Emprestimo: {gerente.ValorEmprestimo}, Taxa de Juros Emprestimo: {gerente.JurosEmprestimo}");
            }

            Console.WriteLine(" ");
            ProcessarGerente(gerente);
        }


    }
}
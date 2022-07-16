using BancoHDevBetterApp.Enums;

namespace BancoHDevBetterApp
{
    public abstract class Conta
    {
        public Conta(TipoConta tipoConta)
        {
            this.TipoConta = tipoConta;
            this.JurosEmprestimo = TipoConta == TipoConta.Cliente ? 30 : TipoConta == TipoConta.Atendente ? 20 : TipoConta == TipoConta.Gerente ? 10 : 0;
        }

        public TipoConta TipoConta { get; set; }
        public double Saldo { get; set; }
        public double JurosEmprestimo { get; set; }
        public double ValorEmprestimo { get; set; }

        public double Depositar(double valor) => Saldo += valor;
        public double VerSaldo() => Saldo;
        public double RealizarEmprestimo(double valor) => ValorEmprestimo = valor;

        public double Sacar(double valor)
        {

            if (Saldo == 0)
                throw new ArgumentException("Você não tem valor para sacar !");

            if (valor > Saldo)
                throw new ArgumentException("Saldo insuficiente !");

            return Saldo -= valor;
        }

        public abstract double CalcularJurosEmprestimo();

    }
}
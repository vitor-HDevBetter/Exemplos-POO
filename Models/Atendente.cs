using BancoHDevBetterApp.Enums;
using System;

namespace BancoHDevBetterApp
{
    public class Atendente : Conta
    {
        public Atendente(TipoConta tipoConta) : base(tipoConta)
        {

        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public int QtdAberturaDeContas { get; set; }

        public override double CalcularJurosEmprestimo()
        {
            if (QtdAberturaDeContas < 20 || Saldo < 6000)
                throw new ArgumentException("Voce nao bateu a meta ou nao tem saldo suficiente para fazer emprestimo");

            return ValorEmprestimo * JurosEmprestimo / 100;
        }
    }
}
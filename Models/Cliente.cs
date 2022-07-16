using System;
using BancoHDevBetterApp.Enums;

namespace BancoHDevBetterApp
{
    public class Cliente : Conta
    {
        public Cliente(TipoConta tipoConta) : base(tipoConta)
        {

        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }

        public override double CalcularJurosEmprestimo()
        {
            if (Saldo < 10000)
                throw new ArgumentException("Voce não tem saldo suficiente para fazer emprestimo");

            return ValorEmprestimo * JurosEmprestimo / 100;
        }
    }
}
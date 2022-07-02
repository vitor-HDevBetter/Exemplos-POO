using BancoHDevBetterApp.Enums;
using System;

namespace BancoHDevBetterApp
{
    public class Gerente : Conta
    {
        public Gerente(TipoConta tipoConta) : base(tipoConta)
        {

        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int QtdConsultorias { get; set; }

        public override double CalcularJurosEmprestimo()
        {
            if (QtdConsultorias < 10 || Saldo < 2000)
                throw new ArgumentException("Voce nao bateu a meta ou nao tem saldo suficiente para fazer emprestimo");

            return ValorEmprestimo * JurosEmprestimo / 100;
        }
    }
}
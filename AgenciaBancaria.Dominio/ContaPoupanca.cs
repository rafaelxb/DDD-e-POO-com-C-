using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            // rende 0,40%
            PercentualRendimento = 0.004M;
        }

        public decimal PercentualRendimento { get; private set; }
    }
}

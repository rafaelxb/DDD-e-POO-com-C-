using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua Teste", "12345678",
                                                 "Cidade Teste", "Estado Teste");

                Cliente cliente = new Cliente("Teste", "12345", "6789", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 50);

                Console.WriteLine("Conta " + conta.Situacao + " : " +
                                  conta.NumeroConta + "-" + 
                                  conta.DigitoVerificador);

                conta.Abrir("teste123");

                Console.WriteLine("Conta " + conta.Situacao + " : " +
                                   conta.NumeroConta + "-" +
                                   conta.DigitoVerificador);

                conta.Sacar(10, "teste123");

                Console.WriteLine("Saldo: " + conta.Saldo);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}

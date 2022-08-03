using BancoByteBank.Entidades;

namespace BancoByteBank
{
    class program
    {
        static void Main(string[] args)
        {
             System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(345, 234567);
            conta.Saldo = 2000;
            

            System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta1 = new ContaCorrente(345, 234567);
            conta.Saldo = 2000;

            System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            
            ContaCorrente conta2 = new ContaCorrente(345, 234567);
            conta.Saldo = 2000;

            System.Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            System.Console.WriteLine(conta.Saldo);

            
            //QUARTA PARTE ---------------------------------------------------------------------------------------

            // Cliente gabriella = new Cliente();
            // gabriella.nome = "Gabriella";
            // gabriella.cpf = "234.432.345-32";
            // gabriella.profissao = "Mecânico";

            // ContaCorrente conta = new ContaCorrente();
            // conta.titular = gabriella;


            // System.Console.WriteLine(conta.titular.nome);
            // System.Console.WriteLine(gabriella.nome);

            
            //-----------------------------------------------------------------------------------------------

            //TERCEIR PARTE

            // ContaCorrente contaBruno = new ContaCorrente();
            // contaBruno.titular = "Bruno";
            // contaBruno.saldo = 1000;

            // ContaCorrente contaGabriella = new ContaCorrente();
            // contaGabriella.titular = "Gabriella";
            // contaGabriella.saldo = 2098;


            // System.Console.WriteLine(contaBruno.saldo);

            // contaBruno.Sacar(1000);

            // System.Console.WriteLine(contaBruno.saldo);

            // contaBruno.Depositar(2000);

            // System.Console.WriteLine(contaBruno.saldo);

            // contaBruno.Transferir(200, contaGabriella);
            // System.Console.WriteLine(contaBruno.saldo);
            // System.Console.WriteLine(contaGabriella.saldo);


            //--------------------------------------------------------------------------------------------------

            //Segunda parte

            // ContaCorrente contaDaGabriella = new ContaCorrente();
            // contaDaGabriella.titular = "Gabriella";
            // contaDaGabriella.agencia = 863;
            // contaDaGabriella.numero = 38763;

            // ContaCorrente contaDaGabriellaCosta = new ContaCorrente();
            // contaDaGabriellaCosta.titular = "GabriellaCosta";
            // contaDaGabriellaCosta.agencia = 863;
            // contaDaGabriellaCosta.numero = 38763;

            //Inicio a orientação a objetos.


            // ContaCorrente contaDaGabriela = new ContaCorrente();
            // contaDaGabriela.titular = "Gabriela";
            // contaDaGabriela.agencia = 863;
            // contaDaGabriela.numero = 863452;
            // contaDaGabriela.saldo = 2000;

            // System.Console.WriteLine(contaDaGabriela.titular);
            // System.Console.WriteLine(contaDaGabriela.numero);
            // System.Console.WriteLine(contaDaGabriela.agencia);
            // System.Console.WriteLine(contaDaGabriela.saldo);

            // contaDaGabriela.saldo += 200;

            // System.Console.WriteLine(contaDaGabriela.saldo);

        }
    }
}
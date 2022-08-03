namespace BancoByteBank.Entidades

{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas {get; private set;}
        public Cliente titular;
        public int Agencia{ get; set;}
        public int Numero{get; set;}

        private double _saldo;

        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        public ContaCorrente (int agencia, int numero)
        {
            agencia = Agencia;
            numero = Numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar (double valor)
        {
            if (_saldo < valor)
            {
                System.Console.WriteLine("O valor a ser sacado não contém em conta");
                
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }
        public void Depositar (double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                System.Console.WriteLine("O valor a ser sacado não contém em conta");
                return false;
            }
            else   
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

    }
}
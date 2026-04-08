class Program
{
  static void Main(string[] args)
  {
    // Conta Corrente 1
    ContaCorrente contaUm = new ContaCorrente();
    contaUm.numeroIdentificacao = 1;
    contaUm.titular = "Tiago";
    contaUm.saldo = 400;
    contaUm.limiteDebito = 1200;

    // Conta Corrente 2
    ContaCorrente contaDois = new ContaCorrente();
    contaDois.numeroIdentificacao = 2;
    contaDois.titular = "Rech";
    contaDois.saldo = 12000;
    contaDois.limiteDebito = 1200;

    while (true)
    {

      Console.Clear();
      Console.WriteLine("===================================================");
      Console.WriteLine($"Conta Corrente #{contaUm.numeroIdentificacao} de {contaUm.titular}");
      Console.WriteLine("===================================================");
      Console.WriteLine("1 - Saque");
      Console.WriteLine("2 - Depósito");
      Console.WriteLine("3 - Transferência");
      Console.WriteLine("4 - Consulta de Saldo");
      Console.WriteLine("S - Sair");
      string? opcaoMenu = Console.ReadLine()?.ToUpper();

      if (opcaoMenu == "S") break;

      if (opcaoMenu == "1")
      {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja sacar (R$): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

        bool conseguiuSacar = contaUm.Sacar(valorSaque);

        if (!conseguiuSacar)
        {
          Console.WriteLine("-------------------------------------");
          Console.WriteLine("O valor do limite de débito foi ultrapassado!");
        }
        else
        {
          Console.WriteLine("-------------------------------------");
          Console.WriteLine("O valor foi sacado com sucesso!");
        }

        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
      }

      else if (opcaoMenu == "2")
      {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja depositar (R$): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        contaUm.Depositar(valorDeposito);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor foi depositado com sucesso!");
        Console.WriteLine("-------------------------------------");

        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
      }

      else if (opcaoMenu == "3")
      {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja transferir (R$): ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        bool sucesso = contaUm.TransferirPara(contaDois, valorTransferencia);

        if (!sucesso)
        {
          Console.WriteLine("-------------------------------------");
          Console.WriteLine($"Não foi possível transferir este valor de R${valorTransferencia}.");
          Console.WriteLine("-------------------------------------");
        }
        else
        {
          Console.WriteLine("-------------------------------------");
          Console.WriteLine($"O valor de R${valorTransferencia} foi tranferido com sucesso!");
          Console.WriteLine("-------------------------------------");

        }

        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
      }

      else if (opcaoMenu == "4")
      {
        decimal saldoAtual = contaUm.ObterSaldo();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor do saldo da conta é de (R$): " + saldoAtual);
        Console.WriteLine("-------------------------------------");

        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
      }

    }
  }
}
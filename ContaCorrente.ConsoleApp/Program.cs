using System.Security.Cryptography;

class Program
{
  static void Main(string[] args)
  {

    ContaCorrente contaUm = new ContaCorrente();
    contaUm.numeroIdentificacao = 1;
    contaUm.titular = "Natalia";

    ContaCorrente contaDois = new ContaCorrente();
    contaDois.numeroIdentificacao = 2;
    contaDois.titular = "Julia";

    while (true)
    {

      Console.Clear();
      Console.WriteLine("===================================================");
      Console.WriteLine($"Conta Corrente #{contaUm.numeroIdentificacao} de {contaUm.titular}");
      Console.WriteLine("===================================================");
      Console.WriteLine("1 - Saque");
      Console.WriteLine("2 - Depósito");
      Console.WriteLine("3 - Consulta de Saldo");
      Console.WriteLine("S - Sair");
      string? opcaoMenu = Console.ReadLine()?.ToUpper();

      if (opcaoMenu == "S") break;

      if (opcaoMenu == "1") contaUm.Sacar();

      else if (opcaoMenu == "2") contaUm.Depositar();

      else if (opcaoMenu == "3") contaUm.TransferirPara(contaDois);

      else if (opcaoMenu == "4") contaUm.ObterSaldo();

    }
  }
}
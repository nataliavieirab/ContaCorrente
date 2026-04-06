using System.Security.Cryptography;

int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 101);
string titular = "Natalia";
decimal saldo = 1000;
decimal limiteDebito = 1200;

while (true)
{

  Console.Clear();
  Console.WriteLine("===================================================");
  Console.WriteLine($"Conta Corrente #{numeroIdentificacao} de {titular}");
  Console.WriteLine("===================================================");
  Console.WriteLine("1 - Saque");
  Console.WriteLine("2 - Depósito");
  Console.WriteLine("3 - Consulta de Saldo");
  Console.WriteLine("S - Sair");
  string? opcaoMenu = Console.ReadLine()?.ToUpper();

  if (opcaoMenu == "S")
    break;

  if (opcaoMenu == "1")
  {
    Console.Write("Digite o valor que deseja sacar (R$): ");
    decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

    if (saldo <= -limiteDebito)
    {
      Console.WriteLine("O valor do limite de débito já foi ultrapassado.");
      Console.ReadLine();
    }
    else
    {
      saldo -= valorSaque;
      Console.WriteLine("O valor foi sacado com sucesso!");
      Console.ReadLine();
    }

  }

  else if (opcaoMenu == "2")
  {
    Console.Write("Digite o valor que deseja depositar (R$): ");
    decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

    saldo += valorDeposito;

    Console.WriteLine("O valor foi depositado com sucesso! ");
    Console.WriteLine($"O valor do saldo da conta é: {saldo}");
    Console.ReadLine();
  }

  else if (opcaoMenu == "3")
  {
    Console.WriteLine($"O valor do saldo da conta é: {saldo}");
    Console.ReadLine();
  }
}
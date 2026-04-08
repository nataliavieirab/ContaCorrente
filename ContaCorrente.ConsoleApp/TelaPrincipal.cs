class TelaPrincipal
{
  public string ApresentarMenu(ContaCorrente contaAcessada)
  {
    Console.Clear();
    Console.WriteLine("===================================================");
    Console.WriteLine($"Conta Corrente #{contaAcessada.numeroIdentificacao} de {contaAcessada.titular}");
    Console.WriteLine("===================================================");
    Console.WriteLine("1 - Saque");
    Console.WriteLine("2 - Depósito");
    Console.WriteLine("3 - Transferência");
    Console.WriteLine("4 - Consulta de Saldo");
    Console.WriteLine("S - Sair");

    return Console.ReadLine()!.ToUpper();
  }

  public void ApresentarOperacaoSaque(ContaCorrente contaAcessada)
  {
    Console.WriteLine("-------------------------------------");
    Console.Write("Digite o valor que deseja sacar (R$): ");
    decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

    bool conseguiuSacar = contaAcessada.Sacar(valorSaque);

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

  public void ApresentarOperacaoDeposito(ContaCorrente contaAcessada)
  {
    Console.WriteLine("-------------------------------------");
    Console.Write("Digite o valor que deseja depositar (R$): ");
    decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

    contaAcessada.Depositar(valorDeposito);

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("O valor foi depositado com sucesso!");
    Console.WriteLine("-------------------------------------");

    Console.Write("Digite ENTER para continuar...");
    Console.ReadLine();
  }

  public void ApresentarOperacaoTransferencia(ContaCorrente contaAcessada, ContaCorrente contaDestino)
  {
    Console.WriteLine("-------------------------------------");
    Console.Write("Digite o valor que deseja transferir (R$): ");
    decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

    bool sucesso = contaAcessada.TransferirPara(contaDestino, valorTransferencia);

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

  public void ApresentarOperacaoObterSaldo(ContaCorrente contaAcessada)
  {
    decimal saldoAtual = contaAcessada.ObterSaldo();

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("O valor do saldo da conta é de (R$): " + saldoAtual);
    Console.WriteLine("-------------------------------------");

    Console.Write("Digite ENTER para continuar...");
    Console.ReadLine();
  }
}
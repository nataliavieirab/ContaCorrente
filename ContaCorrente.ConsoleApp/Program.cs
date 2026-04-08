class Program
{
  static void Main(string[] args)
  {

    ContaCorrente tiago = new ContaCorrente(1, "Tiago", 400, 1200);
    ContaCorrente rech = new ContaCorrente(2, "Rech", 12000, 1200);

    TelaPrincipal tela = new TelaPrincipal();

    ContaCorrente contaAcessada = tiago;
    ContaCorrente contaDestino = rech;

    while (true)
    {

      string opcaoMenu = tela.ApresentarMenu(contaAcessada);

      if (opcaoMenu == "S") break;

      if (opcaoMenu == "1") tela.ApresentarOperacaoSaque(contaAcessada);

      else if (opcaoMenu == "2") tela.ApresentarOperacaoDeposito(contaAcessada);

      else if (opcaoMenu == "3") tela.ApresentarOperacaoTransferencia(contaAcessada, contaDestino);

      else if (opcaoMenu == "4") tela.ApresentarOperacaoObterSaldo(contaAcessada);

    }
  }
}
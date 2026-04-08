class ContaCorrente
{
  public int numeroIdentificacao;
  public string? titular;
  public decimal saldo;
  public decimal limiteDebito;

  public ContaCorrente(int _numeroIdentificacao, string _titular, decimal _saldo, decimal _limiteDebito)
  {
    this.numeroIdentificacao = _numeroIdentificacao;
    this.titular = _titular;
    this.saldo = _saldo;
    this.limiteDebito = _limiteDebito;
  }

  public bool Sacar(decimal valorSaque)
  {
    if (valorSaque > saldo + limiteDebito) return false;

    saldo -= valorSaque;

    return true;
  }

  public void Depositar(decimal valorDeposito)
  {
    saldo += valorDeposito;
  }

  public bool TransferirPara(ContaCorrente contaDestino, decimal valorTransferencia)
  {
    bool conseguiuSacar = this.Sacar(valorTransferencia);

    if (!conseguiuSacar) return false;

    contaDestino.Depositar(valorTransferencia);

    return true;
  }

  public decimal ObterSaldo()
  {
    return this.saldo;
  }
}
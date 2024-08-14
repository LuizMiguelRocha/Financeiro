using Financeiro.Modelos;

namespace Controles;

public class PagarControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PagarControle() : base()
  {
    NomeDaTabela = "ContaPagar";
  }

  //----------------------------------------------------------------------------

  public virtual List<ContaPagar>? LerTodos()
  {
    var tabela = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    return new List<ContaPagar>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(ContaPagar contaPagar)
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    collection.Upsert(contaPagar);
  }

  //----------------------------------------------------------------------------
}
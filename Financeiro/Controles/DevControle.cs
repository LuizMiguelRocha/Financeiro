using Financeiro.Modelos;

namespace Controles;

public class DevControles : BaseControle
{
  //----------------------------------------------------------------------------

  public DevControles() : base()
  {
    NomeDaTabela = "Devedores";
  }

  //----------------------------------------------------------------------------

  public virtual List<Devedores>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Devedores>(NomeDaTabela);
    return new List<Devedores>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Devedores devedores)
  {
    var collection = liteDB.GetCollection<Devedores>(NomeDaTabela);
    collection.Upsert(devedores);
  }

  //----------------------------------------------------------------------------
}
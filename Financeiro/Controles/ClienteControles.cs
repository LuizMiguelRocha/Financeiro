using Financeiro.Modelos;

namespace Controles;

public class ClienteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ClienteControle() : base()
  {
    NomeDaTabela = "ContaPagar";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idContaPagar)
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idContaPagar);
  }

  //----------------------------------------------------------------------------

  public virtual List<ContaPagar>? LerTodos()
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    return new List<ContaPagar>(collection.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idContaPagar)
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    collection.Delete(idContaPagar);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(ContaPagar contapagar)
  {
    var collection = liteDB.GetCollection<ContaPagar>(NomeDaTabela);
    collection.Upsert(contapagar);
  }

  //----------------------------------------------------------------------------
}
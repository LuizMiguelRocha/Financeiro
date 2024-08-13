using LiteDB;

namespace Financeiro.Modelos;

public class Cliente : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nome { get; set; }
  public string Valor { get; set; }

  public string DataValidade { get; set; }
  public string Pedidos { get; set; }
}
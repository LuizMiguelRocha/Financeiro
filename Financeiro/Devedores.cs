namespace Financeiro;
public class Devedores:Gerenciamento
{
      string  Pedidos;
   
     public void SetPedidos (string Pedidos)
   {
    this.Pedidos = Pedidos;
   }
   public string GetPedidos()
   {
    return Pedidos;
   }
}
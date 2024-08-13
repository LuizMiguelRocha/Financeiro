namespace Financeiro.Modelos;
public class Devedores
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

      string Nome;
      string Valor;

   public void SetNome (string Nome)
   {
    this.Nome = Nome;
   }
   public string GetNome()
   {
    return Nome;
   }

   public void SetValor (string Valor)
   {
      this.Valor = Valor;
   }
   public string GetValor()
   {
      return Valor;
   }
}
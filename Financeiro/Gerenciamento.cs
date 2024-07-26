namespace Financeiro;
public class Gerenciamento
{
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
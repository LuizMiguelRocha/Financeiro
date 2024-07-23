namespace Financeiro;
public class ContaPagar:Gerenciamento
{
    string  Validade;
   
     public void SetValidade (string Validade)
   {
    this.Validade = Validade;
   }
   public string GetValidade()
   {
    return Validade;
   }
}    
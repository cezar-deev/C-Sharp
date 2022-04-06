// See https://aka.ms/new-console-template for more information


//--------------------------------------------------------------------------------
// Struct - Estrutura de dados ( armazena o valor em si - Tipo por Valor )
//--------------------------------------------------------------------------------
/*
static void Main (string[] args) 
{
    var Customer = new Customer();
    Customer.Name = "teste";

}

struct Customer  
{ 
    public string Name;
}
*/

//--------------------------------------------------------------------------------
// Encapsulamento - 
//--------------------------------------------------------------------------------

/*
class Pagamento
{
    // Propriedades - (são as variaveis)
    DateTime Vencimento; 
    
    // Metodos - (São as Funções)
    void Pagar() {}
}
*/

//--------------------------------------------------------------------------------
// Abstração - Expor somente o necessário
//--------------------------------------------------------------------------------

class Pagamento
{
    // Propriedades - (são as variaveis)
    DateTime Vencimento; 
    
    // Metodos - (São as Funções)
    void Pagar() {
        ConsultarSaldodoCartao();
    }
    Private void ConsultarSaldodoCartao() {

    }
}
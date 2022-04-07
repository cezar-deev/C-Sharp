


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

/*

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
*/

//--------------------------------------------------------------------------------
// Herança - É a capacidade que um objeto tem de herdar propriedades, metodos e eventos e outro objeto.
//--------------------------------------------------------------------------------

/*
static void Main (string[] args) 
{
    var pagamentoBoleto = new PagamentoBoleto(); // Instanciando um objeto da class PagamentoBoleto 

    pagamentoBoleto.Vencimento = DateTime.Now; // herdando a propriedade da class Pagamento
    pagamentoBoleto.NumeroBoleto = "1234";

    pagamentoBoleto.Pagar(); // herdando o metodo Pagar() da class Pagamento
    pagamentoBoleto.Parcelar();


}

    class Pagamento
    {
        // Propriedades 
        public DateTime Vencimento; 
    
        // Metodos  
        public void Pagar() {}

        public void Parcelar() {}
            
    }
        
    class PagamentoBoleto : Pagamento // Aqui herdo as propriedades e metodos da class pagamento.
    {
        public string NumeroBoleto;
        public string nome;
    }

    class PagamentoCartaocredito : Pagamento 
    {
        public string Numero;
        public string vencimento;
        public string codigo;

    }

    class PagamentoPix: Pagamento 
        {
            public string Numero;
            public string vencimento;
            

    }
    
*/

//--------------------------------------------------------------------------------
// Polimorfismo - poli( muitos ) + morf ( fomra ) - Um metodo,uma classe pode ter diversas formas
//--------------------------------------------------------------------------------

/*
static void Main (string[] args) 
{
    var pagamentoBoleto = new PagamentoBoleto(); // Instanciando um objeto da class PagamentoBoleto 

    pagamentoBoleto.Vencimento = DateTime.Now; // herdando a propriedade da class Pagamento
    pagamentoBoleto.NumeroBoleto = "1234";

    pagamentoBoleto.Pagar(); // herdando o metodo Pagar() da class Pagamento
    pagamentoBoleto.Parcelar();


}

    class Pagamento
    {
        // Propriedades 
        public DateTime Vencimento; 
    
        // Metodos  
        public virtual void Pagar() {} // ( virtual no Pai ) permite que este metodo seja sobre escrito

        public void Parcelar() {}
            
    }
        
    class PagamentoBoleto : Pagamento // Aqui herdo as propriedades e metodos da class pagamento.
    {
        public string NumeroBoleto;
        
        public override void Pagar()  // ( override no filho) estou sobreescrevendo, estou criando uma forma nova de pagar.
        {
            // Descrever Regra do cartão de credito
        }
    }
    
    class PagamentoCartaocredito : Pagamento 
    {

        public string Numero;
        
        public override void Pagar()  // ( override no filho) estou sobreescrevendo, estou criando uma forma nova de pagar.
        {
            // Descrever Regra do cartão de credito
        }

    }

*/

//--------------------------------------------------------------------------------
// Modificadores de acesso - Se estendem a classes, propriedades e metodos
//--------------------------------------------------------------------------------

/*

// Usado em : Classes
// Usado em : propriedades
// Usado em : metodos

// Private    :  Visivel ao escopo da sua classe;
// protected  :  Visivel ao escopo da sua classe + as classes filhos;
// internal   :  Visivel dentro do name space ( quase não se usa );
// public     :  Visivel esta vissivel em qualquer lugar;

// Ao nao colocar nada ela estara privada

*/
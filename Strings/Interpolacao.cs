

//Converte sempre o valor para String

var price = 10.2;
var price2 = 5;
//var texto = "O preço é : " + price; // Forma mais simples e comum
var texto = String.Format("O preço é {0} apenas e nao {1}", price,price2 ); // pega o que esta depois da virgula

Console.WriteLine(texto);


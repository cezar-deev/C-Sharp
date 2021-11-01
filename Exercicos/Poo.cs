/* 

                                                         << CLASSES >> :

Uma classe é uma estrutura que abstrai um conjunto de objetos com características similares. 
Uma classe define o comportamento de seus objetos - através de métodos - e os estados possíveis destes objetos - através de atributos.
Em outras palavras, uma classe descreve os serviços oferecidos por seus objetos e quais informações eles podem armazenar.
Classes não são diretamente suportadas em todas as linguagens, e são necessárias para que uma linguagem seja orientada a objetos.
Uma classe representa um conjunto de objetos com características afins. 
Uma classe define o comportamento dos objetos através de seus métodos, e quais estados ele é capaz de manter através de seus atributos.

A especificação de uma classe é composta por três regiões:

1-CLASSE 
        OBJETOS        
              *2-Atributos
              *3-Métodos


1 - Nome da classe
Um identificador para a classe, que permite referenciá-la posteriormente -- por exemplo, no momento da criação de um objeto.


2 - Atributos : O conjunto de propriedades da classe. Para cada propriedade, especifica-se:
     -> nome: um identificador para o atributo.
     -> tipo: o tipo do atributo (inteiro, real, caráter, etc.)
     -> valor_default: opcionalmente, pode-se especificar um valor inicial para o atributo.
     -> visibilidade: opcionalmente, pode-se especificar o quão acessível é um atributo de um objeto a partir de outros objetos. ValoreSpossíveis são:
             - (privativo), nenhuma visibilidade externa;
             + (público), visibilidade externa total; e
             # (protegido), visibilidade externa limitada.

3 - Métodos : O conjunto de funcionalidades da classe. Para cada método, especifica-se sua assinatura, composta por:
nome: um identificador para o método.
     -> tipo: quando o método tem um valor de retorno, o tipo desse valor.
     ->lista de argumentos: quando o método recebe parâmetros para sua execução, o tipo e um identificador para cada parâmetro.
     ->visibilidade: como para atributos, define o quão visível é um método a partir de objetos de outros classes.

As técnicas de programação orientada a objetos recomendam que a estrutura de um objeto e a implementação de seus métodos devem ser tão privativos como possível.
Normalmente, os atributos de um objeto não devem ser visíveis externamente. Da mesma forma, de um método deve ser suficiente conhecer apenas sua especificação,
sem necessidade de saber detalhes de como a funcionalidade que ele executa é implementada.


                                                             << OBJETOS >> : 

Um objeto, na vida real, é qualquer coisa a qual pudermos dar um nome.
Um objeto, em programação orientada a objetos, é uma instância (ou seja, um exemplar) de uma classe. 
A Wikilivros é um exemplo de Wiki, ou, a Wikilivros é uma instância de Wiki. Isto poderia ser representado em um programa orientado a objetos com uma
classe chamada Wiki e um objeto do tipo Wiki chamado Wikilivros.
Um objeto é capaz de armazenar estados através de seus atributos e reagir a mensagens enviadas a ele, assim como se relacionar e enviar mensagens a outros objetos.


*Atributos : são características de um objeto. Basicamente a estrutura de dados que vai representar a classe.
um objeto da classe "Funcionário" teria como atributos "nome", "endereço", "telefone", "CPF", etc
O conjunto de valores dos atributos de um determinado objeto é chamado de estado.




                                                              << HERANÇA >> 

 É um princípio de orientação a objetos, que permite que classes compartilhem atributos e métodos, através de "heranças". 
 Ela é usada na intenção de reaproveitar código ou comportamento generalizado ou especializar operações ou atributos. 
 O conceito de herança de várias classes é conhecido como herança múltipla. Como exemplo pode-se observar as classes 'aluno' e 'professor', 
 onde ambas possuem atributos como nome, endereço e telefone. Nesse caso pode-se criar uma nova classe chamada por exemplo, 'pessoa', 
 que contenha as semelhanças entre as duas classes, fazendo com que aluno e professor herdem as características de pessoa, 
 desta maneira pode- se dizer que aluno e professor são subclasses de pessoa. Também podemos dizer que uma classe pode ser abstrata(abstract) ou 
 seja ela não pode ter uma instância, ela apenas "empresta" seus atributos e metódos como molde para novas classes.

                                                             << ABSTRAÇÃO >>
 
 É a habilidade de concentrar nos aspectos essenciais de um contexto qualquer, ignorando características menos importantes ou acidentais. 
 Em modelagem orientada a objetos, uma classe é uma abstração de entidades existentes no domínio do sistema de software.

Por exemplo, imaginamos a abstração referente a classe Animais. Há várias entidades na classe Animais como Anfíbios, 
Répteis e Mamíferos que são também sub-classes da classe Animais, onde há objetos que contêm cada sub-classe como Ser-humano, Jacaré e outros
 
*/            



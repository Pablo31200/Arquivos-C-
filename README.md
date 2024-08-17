# Arquivos-C-
Programas utilizando linguagem C#
Este repositório contém vários exemplos e exercícios em C# para ajudar no aprendizado e prática da linguagem. Cada arquivo apresenta um conceito ou funcionalidade diferente do C#.

*É válido destacar que conforme o tempo for passando, o READ-ME será atualizado no acompanhamento das atividades.

Arquivos
Programa_01.cs
Este arquivo é um exemplo básico de um programa em C# que imprime "Olá, mundo!" no console. Ele demonstra:

Uso de diretivas using para incluir namespaces.
Configuração do encoding do console para UTF-8.
Uso do método Console.WriteLine para exibir uma mensagem no console.
Exercício_02.cs
Este arquivo contém um sistema em que o usuário insere seu nome e data de nascimento, e o sistema retorna seu nome e idade. Ele demonstra:

Entrada de dados do usuário.
Conversão de strings para DateTime.
Cálculo de idade.
Uso de condicionais para validação de entrada.
Teste_01.cs
Este arquivo é um exemplo simples onde o usuário insere seu nome e o sistema responde com uma mensagem personalizada. Ele demonstra:

Entrada de dados do usuário.
Uso de interpolação de strings para exibir mensagens personalizadas.
---------------------------------------------------------------------------------------------------------------------------------------
Sistema de Avaliação de Estudantes: 
*Gerenciamento de Notas de Alunos;

Este projeto em C# é um programa de gerenciamento de notas de alunos que permite ao usuário inserir informações sobre os alunos, sendo essas: Nome, Idade, Notas nas matérias de Português e matemática, se o aluno é bolsista, e por último, adição de demais alunos. O programa calcula a média das notas, determina se o aluno foi aprovado ou reprovado, e verifica se o aluno perdeu a bolsa de estudos caso a média esteja abaixo de 8.0. Além disso, o programa exibe as diferentes representações dos caracteres no nome do aluno e permite que o usuário adicione informações de vários alunos.

Funcionalidades: 

1º - Inserção de nome e idade do aluno.
2º - Inserir notas em Português e Matemática.
3º - Verificar se o aluno possui bolsa de estudos.
4º - Cálculo da média das notas e determinar se o aluno foi aprovado ou reprovado.
5º - Verifica se o aluno com bolsa de estudos perdeu a bolsa.
6º - Exibe diferentes representações dos caracteres no nome do aluno.
7º - Permite a inserção de múltiplos alunos.
8º - Calcula a média final das notas de todos os alunos cadastrados.

Uso: 

* O programa solicita ao usuário para inserir o nome e a idade do aluno.
* O usuário insere as notas em Português e Matemática.
* O programa calcula a média dessas notas.
- Se a média for maior ou igual a 6.0, o aluno é aprovado; caso contrário, ele é reprovado.
- Se o aluno tiver bolsa de estudos e a média for inferior a 8.0, o aluno perde a bolsa.
* O programa exibe as diferentes representações dos caracteres no nome do aluno.
* O usuário do sistema pode optar por adicionar informações de outro aluno ou finalizar o programa.
- Ao final, o programa calcula e exibe a média das notas de todos os alunos cadastrados.

Estrutura do Código:

Algumas diretivas e estruturas do código: 

* foreach: Foi utilizado para iterar sobre os caracteres do nome do aluno. Essa abordagem é necessária porque o nome é uma string e, ao tentar iterá-la diretamente, seria difícil trabalhar com cada caractere individualmente. O foreach garante que cada caractere da string seja iterado para as representações correspondentes.

* using System.Collections.Generic;: Incluído para permitir o uso da coleção List<decimal>, que é utilizada para armazenar as notas dos alunos.

* using System.Linq;: Adicionado porque na última etapa do código utilizamos o método Average para calcular a média das notas, simplificando o código.
--------------------------------------------------------------------------------------------------------------------------------------------------------------

Cálculo da Média Final de Forma Manual

Embora o código utilize a função Average() da biblioteca System.Linq para calcular a média das notas de todos os alunos, existe uma maneira mais manual de realizar este cálculo, o que dispensa o uso de System.Linq.

Passos para o Cálculo Manual:
Somar Todas as Notas: Crie uma variável para armazenar a soma das notas.
 - decimal somaNotas = 0;
foreach (var nota in Notas)
{
    somaNotas += nota;
}


Dividir a Soma pelo Número Total de Notas: Calcule a média dividindo a soma das notas pela quantidade de elementos na lista.
decimal mediaFinal = somaNotas / Notas.Count;


Exibir a Média Final: Por fim, a média final é exibida no console.
Console.WriteLine($"\nA média das notas de todos os alunos cadastrados é: {mediaFinal:F2}");

*Essa abordagem de código pode ser útil se você quiser evitar dependências externas ou entender melhor o que está acontecendo no cálculo da média.

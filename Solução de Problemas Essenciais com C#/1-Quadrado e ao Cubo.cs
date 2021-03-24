/*
1 / 5 - Quadrado e ao Cubo

Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.

 
Exemplo de Entrada	Exemplo de Saída
5

1 1 1
2 4 8
3 9 27
4 16 64
5 25 125
*/


using System;

class Desafio {
    static void Main() {
        var N = Int32.Parse(Console.ReadLine());
        
        if(N != null) {
          for(int i=1; i <= N; i++){
            var resultado = $"{i} {i * i} { i * i * i}";
            
            Console.WriteLine(resultado);
          }
        } else {
          Console.WriteLine("Insira um número válido");
        }
    }
}


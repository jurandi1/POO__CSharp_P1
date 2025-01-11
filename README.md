# Classes, Atributos, Métodos e Membros Estáticos em C#

## Índice
- [Introdução](#introducao)
- [Classes](#classes)
- [Atributos](#atributos)
- [Métodos](#metodos)
- [Membros Estáticos](#membros-estaticos)
- [Conclusão](#conclusao)

## Introdução
Este documento fornece uma visão geral sobre a definição e utilização de classes, atributos, métodos e membros estáticos na linguagem de programação C#. 

## Classes
Em C#, uma **classe** é uma estrutura que pode conter dados (campos) e métodos para manipular esses dados. Ela serve como um molde para criar objetos. 

### Sintaxe
```csharp
public class NomeDaClasse
{
    // Campos, propriedades, métodos, etc.
}
```
## Atributos
**Atributos** são variáveis definidas dentro de uma classe. Eles representam o estado ou dados de um objeto. 

### Exemplo
```csharp
public class Pessoa
{
    public string Nome;
    public int Idade;
}
```
## Métodos
**Métodos** são funções definidas dentro de uma classe que descrevem as ações que um objeto pode realizar. 

### Exemplo
```csharp
public class Pessoa
{
    public string Nome;
    public int Idade;

    public void Cumprimentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}.");
    }
}
```
## Membros Estáticos
**Membros Estáticos** são pertencentes à própria classe e não a instâncias da classe. Eles são usados quando precisamos de um comportamento ou dado que seja comum a todas as instâncias da classe. 

### Exemplo
```csharp
public class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}
```
## Conclusão
Este documento abordou os conceitos básicos de classes, atributos, métodos e membros estáticos em C#. Essas são ferramentas fundamentais para a programação orientada a objetos em C# e fornecem uma base sólida para o desenvolvimento de software robusto e escalável.

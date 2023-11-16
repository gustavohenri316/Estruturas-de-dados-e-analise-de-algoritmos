# una-lista-07-csharp
Repositório destina a resolução da Lista de Exercício VII. UC: Estrutura de Dados e Análise de Algoritmos

## Lista e Pilha

Lista e Pilha são coleções que armazenam elementos.
Uma lista é uma coleção de elementos ordenados, onde cada elemento é acessado por seu índice. Ela permite adicionar, remover e acessar elementos em qualquer posição.
Uma pilha é uma coleção de elementos onde o último elemento adicionado é o primeiro a ser removido, seguindo o princípio "LIFO" (Last-In, First-Out), sendo possível apenas adicionar e remover elementos no topo da pilha.

### Exemplo de Lista em C#

```csharp
 List<int> listaExemplo = new List<int>();

        // Adicionar elementos à lista
        listaExemplo.Add(5);
        listaExemplo.Add(25);
        listaExemplo.Add(2);

        // Acessar elementos por índice
        Console.WriteLine(listaExemplo[0]); // Saída: 5

        // Remover elementos
        listaExemplo.Remove(2);
```

### Exemplo de Pilha em C#

```csharp
Stack<string> pilhaExemplo = new Stack<int>();

        // Adicionar elementos à pilha
        pilhaExemplo.Push(2);
        pilhaExemplo.Push(5);
        pilhaExemplo.Push(1);

        // Remover o elemento no topo
        pilhaExemplo.Pop();

        // Acessar o elemento no topo
        int elementoTopo = pilhaExemplo.Peek(); // Elemento: 2
```
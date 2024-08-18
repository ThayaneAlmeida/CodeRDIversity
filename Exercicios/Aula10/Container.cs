using System;
using System.Collections.Generic;
public class Container 
{
    public List<Item> Itens { get; private set; }
    private int tamanho;

    public Container(int tamanho = 4)
    {
        this.tamanho = tamanho;
        Itens = new List<Item>(new Item[tamanho]);
    }

    public bool AdicionarItem(int posicao, Item item)
    {
        if (posicao < 0 || posicao >= tamanho)
        {
            Console.WriteLine("Digite uma posição válida.");
            return false;
        }

         if (Itens[posicao] == null)
        {
            Itens[posicao] = item;
            Console.WriteLine($"O Item '{item.NomeItem}' foi adicionado na posição {posicao}.");
            return true;
        }
        else
        {
            Console.WriteLine($"A posição {posicao} já possui um item.");
            return false;
        }
    }

    public bool RemoverItem(int posicao)
    {
        if (posicao < 0 || posicao >= tamanho)
        {
            Console.WriteLine("Digite uma posição válida.");
            return false;
        }

        if (Itens[posicao] != null)
        {
            Console.WriteLine($"O item '{Itens[posicao].NomeItem}' removido da posição {posicao}.");
            Itens[posicao] = null;
            return true;
        }
        else
        {
            Console.WriteLine($"A posição {posicao} não possui um item.");
            return false;
        }
    }

    public bool AdicionarItens(Item[] itens)
    {
        if (Itens.Count + itens.Length > tamanho)
        {
            Console.WriteLine("Não é possível adicionar mais itens do que o tamanho do container.");
            return false;
        }

        for (int i = 0; i < tamanho; i++)
        {
            if (Itens[i] == null && i < itens.Length)
            {
                Itens[i] = itens[i];
                Console.WriteLine($"O item '{itens[i].NomeItem}' adicionado na posição {i}.");
            }
            else if (i < itens.Length && Itens[i] != null)
            {
                Console.WriteLine($"A posição {i} está ocupada. Não foi possível adicionar o item:'{itens[i].NomeItem}'.");
                return false;
            }
        }
        return true;
    }

    public bool RemoverItens()
    {
        bool removido = false;
        for (int i = 0; i < tamanho; i++)
        {
            if (Itens[i] != null)
            {
                Console.WriteLine($"O item '{Itens[i].NomeItem}' foi removido da posição {i}.");
                Itens[i] = null;
                removido = true;
            }
        }

        if (!removido)
        {
            Console.WriteLine("O container já está vazio.");
            return false;
        }

        return true;
    }
}

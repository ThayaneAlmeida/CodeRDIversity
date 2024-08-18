public class Geladeira
{
    private List<Andar> andares;

    public Geladeira()
    {
        andares = new List<Andar>();
        for (int i = 0; i < 3; i++)
        {
            andares.Add(new Andar());
        }
    }

    public bool AdicionarItem(int andar, int container, int posicao, Item item)
    {
        if (andar < 0 || andar >= 3 || container < 0 || container >= 2)
        {
            Console.WriteLine("Não é possível adicionar o item, essa posição não existe na geladeira");
            return false;
        }

         return andares[andar].Containers[container].AdicionarItem(posicao, item);
    }

    public bool RemoverItem(int andar, int container, int posicao)
    {
        if (andar < 0 || andar >= 3 || container < 0 || container >= 2)
        {
            Console.WriteLine("Não é possível remover o item, essa posição não existe na geladeira");
            return false;
        }

        return andares[andar].Containers[container].RemoverItem(posicao);
    }

   public bool AdicionarItens(int andar, int container, Item[] itens)
    {
        if (andar < 0 || andar >= 3 || container < 0 || container >= 2)
        {
            Console.WriteLine("Não foi possível adicionar o item");
            return false;
        }

        return andares[andar].Containers[container].AdicionarItens(itens);
    }

    public bool RemoverItens(int andar, int container)
    {
        if (andar < 0 || andar >= 3 || container < 0 || container >= 2)
        {
            Console.WriteLine("Não foi possível remover o item.");
            return false;
        }

        return andares[andar].Containers[container].RemoverItens();
    }
}
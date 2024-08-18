// See https://aka.ms/new-console-template for more information

// Thayane Gonçalo de Almeida
Console.WriteLine("----- Geladeira da Thayane -----");

        Geladeira geladeira = new Geladeira();

        //Adicionar item
        Console.WriteLine("Adicionando item");
        Item item1 = new Item("Suco");
        Item item2 = new Item("Margarina");
        Item item3 = new Item("Queijo");

        geladeira.AdicionarItem(0, 0, 0, item1);
        geladeira.AdicionarItem(0, 0, 1, item2);
        geladeira.AdicionarItem(0, 0, 2, item3);

        // Remover item
        Console.WriteLine("Removendo item");
        geladeira.RemoverItem(0, 0, 1);

        // Adicionar múltiplos itens
        Console.WriteLine("Adicionando múltiplos itens");
        Item[] itens = { new Item("Iogurte"), new Item("Leite") };
        geladeira.AdicionarItens(1, 1, itens);

        // Remover múltiplos itens
        Console.WriteLine("Removendo múltiplos itens");
        geladeira.RemoverItens(0, 1);
    


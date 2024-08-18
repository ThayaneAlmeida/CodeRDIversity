public class Andar
{
    public List<Container> Containers { get; private set; }

    public Andar()
    {
        Containers = new List<Container>();
        for (int i = 0; i < 2; i++)
        {
            Containers.Add(new Container());
        }
    }
}
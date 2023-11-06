using Library;

public class SumaEdades : Ivisitor
{
    public int SumEdad {get; private set;}

    public SumaEdades()
    {
            SumEdad = 0;
    }

    public void visitar(FamiliaNode familiaNode)
    {
        SumEdad += familiaNode.Person.Edad;

        foreach (var child in familiaNode.Children)
        {
            child.Accept(this); // Visitamos a los hijos de forma recursiva para acumular sus edades
        }
    }

}
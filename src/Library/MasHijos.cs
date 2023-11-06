using Library;

public class MasHijos : Ivisitor
{
    public int hijos {get; private set;}
    public string quien {get; private set;}

    public MasHijos()
    {
            hijos = 0;
            quien = "";
    }

    public string NodoConMasHijos()
    {
        return $"{quien} con {hijos}";
    }

    public void visitar(FamiliaNode familiaNode)
    {
        int hojas = familiaNode.Children.Count;

        if (hojas > hijos){  //en teoria lo qu estamos mandando es quien tiene mas hijos, pero ante dos con la misma cantidad, se queda con el primero que encuentra, si pusieramos >= se quedaria con el ultimo que encontro
            hijos = hojas;
            quien = familiaNode.Person.Nombre;
        }

        foreach (var child in familiaNode.Children)
        {
            child.Accept(this); // Visitamos a los hijos de forma recursiva para revisar toda la familia
        }
    }

}

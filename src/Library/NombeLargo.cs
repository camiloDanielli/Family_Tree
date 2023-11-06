using Library;

public class NombreLargo : Ivisitor
{
    public string MasLargo {get; private set;}

    public NombreLargo()
    {
            MasLargo = "";
    }

    public void visitar(FamiliaNode familiaNode)
    {
        string nombre = familiaNode.Person.Nombre;

        if (nombre.Length > MasLargo.Length){  //en teoria lo qu estamos mandando es el más largo, pero ante dos del mismo largo, se queda con el primero que encuentra, si pusieramos >= se quedaria con el ultimo que encontro
            MasLargo = nombre;
        }

        foreach (var child in familiaNode.Children)
        {
            child.Accept(this); // Visitamos a los hijos de forma recursiva para revisar todos los nombres
        }
    }

}
using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            FamiliaNode n1 = new FamiliaNode(new Person("pedro", 60));
            FamiliaNode n2 = new FamiliaNode(new Person("juliana", 40));
            FamiliaNode n3 = new FamiliaNode(new Person("armando", 16));
            FamiliaNode n4 = new FamiliaNode(new Person("elias", 20));
            FamiliaNode n5 = new FamiliaNode(new Person("michel", 40));
            FamiliaNode n6 = new FamiliaNode(new Person("mariana", 20));
            FamiliaNode n7 = new FamiliaNode(new Person("stanley", 1));

            n1.AddChildren(n2);
            n1.AddChildren(n5);

            n2.AddChildren(n3);
            n2.AddChildren(n4);
            
            n5.AddChildren(n6);

            n6.AddChildren(n7);

            // visitar el árbol aquí
            var SumaEdades = new SumaEdades();
            n1.Accept(SumaEdades);

            Console.WriteLine(SumaEdades.SumEdad);

            var NombreLargo = new NombreLargo();
            n1.Accept(NombreLargo);

            Console.WriteLine(NombreLargo.MasLargo);

            var MasHijos = new MasHijos();
            n1.Accept(MasHijos);

            Console.WriteLine(MasHijos.NodoConMasHijos());
        }
    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class FamiliaNode : Node
    {
        private Person person;

        public Person Person
        {
            get { return person; }
        }

        public FamiliaNode(Person person)
        {
            this.person = person;
        }

        public string GetPerson()
        {
            return person.GetPerson();
        }

        public override void Accept(Ivisitor visitor)
        {
            visitor.visitar(this);
        }
    }
}

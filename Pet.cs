using System.Runtime.InteropServices;

namespace Practice1
{
    public abstract class Pet
    {
        private string _name;
        private int _age;
        private string _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    

        public Pet()
        {
            Name = "Spot";
            Age = 0;
            Type = "Cat";

        }

        public Pet(string inName, int inAge, string inType)
        {
            Name = inName;
            Age = inAge;
            Type = inType;
        }

        public string DisplayPet()
        {
            return $"{Name} is {Age} years old & is a {Type}!";
        }

        //Creating a virtual method to use.
        public abstract string Speak();
            //override this on ALL :)
    

    }
}

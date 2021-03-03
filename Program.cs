using System;

namespace Project1
{

    class Cars
    {
        public string Name { get; set; }
    }

    class Street
    {
        private string v1;
        private int v2;

        public Street(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        private string Name
        { get; set; }

        private double Lenght
        { get; set; }

    }

    public class Parks
    {
        private string name;
        private double size;

        public Parks(string name, double size)
        {
            name = name;
            size = size;
        }
        public string ToString()
        {
            return "Name" + name + "size" + size;
        }
    }
    abstract class Buildings
    {
        private int Adress;
        private string name;
        public Buildings(int Adress, string name)
        {
            this.Adress = Adress;
            this.name = name;
        }

        public string ToString()
        {
            return " Adress " + Adress + "area" + name;
        }
    }

    class Shops : Buildings
    {
        private string _name;
        public Shops(string name, int Adress, double area) : base( Adress, name)
        {
            this._name = name;
        }
        public string Name { get => _name; set => _name = value; }
        public string ToString()
        {
            return "Shop: " + Name + base.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cars cars1 = new Cars();
            Street street = new Street("Avram Iancu", 123);
            Parks park = new Parks("Disneyland", 14500);
            Buildings buildings1 = new Buildings(456, "house");
            Buildings shops = new Shops("Penny", 73, 56);
        }
    }
}

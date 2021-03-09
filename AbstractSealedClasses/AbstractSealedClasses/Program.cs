using System;

namespace AbstractSealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("Macintosh", .5);
            Console.WriteLine("Type: {0}, cost per dozen: {1}", apple.Kind, apple.GetCost());
        }
    }
    abstract class Apple // base class; abstract can not be called directly (instantied)
    {
        public string Kind { get; protected set; }
        public double Cost { get; protected set; }
        abstract public string GetCost();//using "abstract" in this line then see comment below
    }// using abstract classes, this enables methods to be called in these abstract classes
    sealed class Fruit : Apple // derived class; Sealed cannot be used for base classes
    {
       
        public Fruit(string k, double c)
        {
            Kind = k;
            Cost = c;
        }
        public string GetFruit()
        {
            return Kind;
        }
        sealed public override string GetCost()//overide has to be placed, so application can run through abstract
        {// placing Sealed infront GetCost, therefor getCost can't be overwritten anymore and it's made secure  
            return "$" + Cost * 12;
        }
    }
}

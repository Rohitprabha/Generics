using System;

namespace Generic_Method
{
    public class ClassA
    {
        public void Display<T, S>(T msg, S value)         //Generic Method
        {
            Console.WriteLine("{0} : {1}", msg, value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Display<string, int>("Integer", 122);
            a.Display<string, char>("Character", 'H');
            a.Display<string, float>("Float", 25.87f);
        }
    }
}

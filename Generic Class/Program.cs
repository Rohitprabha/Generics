using System;

namespace Generic_Class
{
    public class Generic_Class<T>
    {
        private T temp;
        public Generic_Class(T temp)
        {
            this.temp = temp;
        }
        public void Display()
        {
            Console.WriteLine(temp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic_Class<int> Obj = new Generic_Class<int>(10);
            Obj.Display();
            Generic_Class<string> Obj1 = new Generic_Class<string>("Rohit");
            Obj1.Display();
            Generic_Class<float> Obj2 = new Generic_Class<float>(1.004f);
            Obj2.Display();

        }
    }
}

using System;

namespace Classy
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new String("pitbull");
            string[] sList = { "dog", "cat", "rabbit", "hamster" };
            float[] fList = { 0f, 1f, 2f, 3f, 4f };

           foreach(string x in sList)
            {
                string greeting = x + " " + "dog";
                Console.WriteLine(sList);
            }
            
               }

        }

    }

    class animal
    {
    
        public String _name { get; set; }

        public int _breed { get; set; }
        public animal(string name, int breed)
        {
            _name = name;
            _breed = breed;
        }
    class dog
    {
        
        public String _name { get; set; }
        public int _breed { get; set; }
    }public void Bark()
        {
            Console.WriteLine("The dog is barking");
        }
     class Cat
    {
       

        public String _name { get; set; }

        public int _sixtoes { get; set; }

    public void Meow()
        {
            Console.WriteLine("The cat is meowing");
         }
   
         

        bool sixtoes = true;
        //conditional statements

        bool fivetoes = false;

        public void myMethod1()
        {
            Console.WriteLine("There are many breeds of dogs");
        }

        public void myMethod2()
        {

            Console.WriteLine("Cats are finnicky");
        }

        string[] sList = { "dog", "cat", "rabbit", "hamster" };
        float[] fList = { 0, 1, 2, 3, 4 };

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeTask
{
    class Pet
    {
       //fields will be inherited in derived classes.
       protected string name, breed;

       //initialization of the fields in constructor
        protected Pet(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

       //method describing pet
        public void Introduce()
        {
            Console.WriteLine("I’m {0} of {1}. I’m a {2}", name,breed,this.GetType().Name);
        }
    }
    class Cat : Pet
    {
        //use base constructor
        public Cat(string name, string breed):base(name,breed)
        {
            
        }
       
    }
    class Dog : Pet
    {
         public Dog(string name, string breed):base(name,breed)
        {
           
        }
        
    }
}

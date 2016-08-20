using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeTask
{
    /// <summary>
    /// Create next classes: Cat, Dog and Petshop.Types Cat and Dog have fields Name and Breed and method Introduce() which prints
    /// text “I’m (Name) of (Breed). I’m a cat (or dog)”.The class Petshop collects in its container different pets.We may add new
    /// pet to container by method AddPet() and we may display information about all pets by method IntroduceAll().
    /// Which hierarchy of classes is the best solution of this problem? Write short code to demonstrate your solution.
    /// Your code should include class (interface) aggregation, inheritance, should use .NET BCL collections or generics,
    /// should implement exception handling.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //creating new instances of  classes describing  pets
            Pet p1 = new Dog("Rick", "dachshund");
            Pet p2 = new Dog("Nick", "shepherd");
            Pet p3 = new Cat("Sara", "siamese");
            Pet p4 = new Cat("Juja", "сeylon");

            //Pet p5 = new Pet("Pet", "abstract pet"); we can not  create instances of base class

            //creating new instance of Petshop class
            Petshop shop = new Petshop();
            //Addition instances of classes Dog and Cat to pet container
            shop.AddPet(p1);
            shop.AddPet(p2);
            shop.AddPet(p3);
            shop.AddPet(p4);
            //we may display information about all pets

            try
            {
                 shop.IntroduceAll();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            

            //Delay

            Console.ReadKey();

           
        }
    }
}

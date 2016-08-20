using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeTask
{
    class Petshop
    {
        //container for pets
        List<Pet> pets = null;
        //initialization of the container in base constructor
        public Petshop()
        {
            pets = new List<Pet>();
        }
        // method for addition new pet to container
        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }
        //method for showing information about all pets
        public void IntroduceAll()
        {
            if (pets.Count == 0)
            {
                throw new Exception("the container is without pets");
            } 
            foreach (var item in pets)
            {
                item.Introduce();
            }
        }
    }
}

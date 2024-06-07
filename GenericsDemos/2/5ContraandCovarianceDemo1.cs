using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public interface ICovariant<out T>
    {
        T Get();
    }

    public class CovariantClass<T> : ICovariant<T>
    {
        private T _value;

        public CovariantClass(T value)
        {
            _value = value;
        }

        public T Get()
        {
            return _value;
        }
    }


    public interface IContravariant<in T>
    {
        void Set(T value);
    }

    public class ContravariantClass<T> : IContravariant<T>
    {
        public void Set(T t)
        {
            Console.WriteLine(t.ToString());
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public override string ToString()
        {
            return $"{Name} the {Breed}";
        }
    }

    internal class ContraandCovarianceDemo1
    {
        static void Main()
        {
            //Covariant Demo
            ICovariant<Animal> animalCovariant = new CovariantClass<Dog>(new Dog { Name = "Buddy", Breed = "Golden Retriever" });
            Animal animal = animalCovariant.Get();
            Console.WriteLine(animal.Name);

            //Contra variant Demo
            IContravariant<Dog> dogContravariant = new ContravariantClass<Animal>();           
            dogContravariant.Set(new Dog { Name = "Buddy", Breed = "Golden Retriever" }); 
        }
    }
}

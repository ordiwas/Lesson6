using System;
// define a generics class named Student
public class Animal<T>
{
    // define a field of type T 
    public T data;
    public T getAnimal()
    {
        return data;
    }

    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
}

class Program
{
    static void Main()
    {
        // create an instance with a string data type
        Animal<string> animalName = new Animal<string>("Mickey Mouse");

        Animal<string> animalHabitat = new Animal<string>("Club House");

        // create an instance with an int data type
        Animal<int> averageLifespan = new Animal<int>(50);

        // create an instance with another string data type
        Animal<Boolean> endangered = new Animal<Boolean>(true);

        Animal<Boolean> extinct = new Animal<Boolean>(false);

        // C# recognizes that the objects created with the generic are not the same
        Console.WriteLine(animalName.getAnimal());
        Console.WriteLine(animalHabitat.getAnimal());
        Console.WriteLine("Life span-");
        Console.WriteLine(averageLifespan.getAnimal());
        Console.WriteLine("Endangered?");
        Console.WriteLine(endangered.getAnimal());
        Console.WriteLine("Extinct?");
        Console.WriteLine(extinct.getAnimal());
        Console.Read();
    }
}
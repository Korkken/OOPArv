// Tim Lappalainen #NET2024
using OOPArv;

List<Animal> DomesticAnimals = new List<Animal> {
new Cat("Mittens", 4, "Meow", "Fish", "Home"),
new Dog("Buddy", 4, "Woof", "Dog food", "Park")
};
List<Animal> WildAnimals = new List<Animal> {
new Bear("Bears", 4, "Growl", "Fish", "Forest")
};//(string name, string numberoflegs, string sound, string food, string habitat)

Console.WriteLine("Vilda djur:");
foreach (Animal WildAnimal in WildAnimals)
{
    WildAnimal.MakeSound();
}
Console.WriteLine("Inte vilda djur:");
foreach (Animal DomesticAnimal in DomesticAnimals)
{
    
    DomesticAnimal.MakeSound();
}
List<Dog> dogs = new List<Dog>
{
    new Chihuahua("bert", 4, "mini woof", "chips", "park", "Very small"),
    new Collie("luna", 4, "woof", "meat", "home", "Medium sized")
};
Console.WriteLine("Hundar:");
foreach (Dog Dog in dogs)
{ Dog.MakeSound(); }
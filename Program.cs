//using Pattern_Prototype.Classes;


//namespace Pattern_Prototype
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var pet = new Pet("Buddy", "John");
//            var wildAnimal = new WildAnimal("Lion", "Savanna");
//            var homePet = new HomePet("Whiskers", "Jane", true);

//            var clonedPet = (Pet)pet.Clone();
//            var clonedWildAnimal = (WildAnimal)wildAnimal.Clone();
//            var clonedHomePet = (HomePet)homePet.Clone();

//            Console.WriteLine("Original pet:");
//            Console.WriteLine($"Name: {pet.Name}, Owner: {pet.Owner}");
//            Console.WriteLine("Cloned pet:");
//            Console.WriteLine($"Name: {clonedPet.Name}, Owner: {clonedPet.Owner}");

//            Console.WriteLine("Original wild animal:");
//            Console.WriteLine($"Name: {wildAnimal.Name}, Habitat: {wildAnimal.Habitat}");
//            Console.WriteLine("Cloned wild animal:");
//            Console.WriteLine($"Name: {clonedWildAnimal.Name}, Habitat: {clonedWildAnimal.Habitat}");

//            Console.WriteLine("Original home pet:");
//            Console.WriteLine($"Name: {homePet.Name}, Owner: {homePet.Owner}, IsHousebroken: {homePet.IsHousebroken}");
//            Console.WriteLine("Cloned home pet:");
//            Console.WriteLine($"Name: {clonedHomePet.Name}, Owner: {clonedHomePet.Owner}, IsHousebroken: {clonedHomePet.IsHousebroken}");
//        }
//    }
//}

class Program
{
	static void Main(string[] args)
	{
		var lion = new Animal("Лев", "Ссавець", 80);
		var parrot = new Animal("Папуг", "Птиця", 120.0);

		var cherry = new Plant("Сакура", "Tree", 20);
		var pine = new Plant("Сосна", "Tree", 30);
		var bamboo = new Plant("Бамбук", "Grass", 10);

		var animalAccessor = new AnimalAccessor();
		Console.WriteLine("Animal Information:");

		var animals = new[] { lion, parrot };

		foreach (var animal in animals)
		{
			Console.WriteLine($"Ім'я: {animalAccessor.GetNormalizedName(animal)}, Класс: {animalAccessor.GetNormalizedClass(animal)}, Швидкість: {animalAccessor.GetSpeed(animal)} km/h");
		}

		var plantAccessor = new PlantAccessor();
		Console.WriteLine("\nPlant Information:");

		var plantsInfo = new[]
		{
			(cherry, "Сакура"),
			(pine, "Сосна"),
			(bamboo, "Бамбук")
		};

		foreach (var (plant, name) in plantsInfo)
		{
			Console.WriteLine($"Ім'я: {plantAccessor.GetNormalizedName(plant)}, Класс: {plantAccessor.GetNormalizedClass(plant)}, Висота: {plant.Height} метрів");
		}

		var plants = new[] { cherry, pine, bamboo };

		Plant tallestPlant = plantAccessor.GetHighestPlant(plants);

		Console.WriteLine($"\nНайдовша рослина: {tallestPlant.Name} висотою {tallestPlant.Height} метрів.");
	}
}

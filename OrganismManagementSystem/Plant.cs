public class Plant : Organism
{
	public double Height { get; }

	public Plant(string name, string className, double height)
		: base(name, className)
	{
		Height = height;
	}
}

public class Animal : Organism
{
	public double Speed { get; }

	public Animal(string name, string className, double speed)
		: base(name, className)
	{
		Speed = speed;
	}
}

public abstract class Organism
{
	public string Name { get; }
	public string ClassName { get; }

	protected Organism(string name, string className)
	{
		Name = name;
		ClassName = className;
	}
}

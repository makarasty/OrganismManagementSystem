public class AnimalAccessor : OrganismAccessor<Animal>
{
	public double GetSpeed(Animal animal)
	{
		return animal.Speed;
	}
}

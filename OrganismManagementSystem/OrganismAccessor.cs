public class OrganismAccessor<T> where T : Organism
{
	public string GetNormalizedName(T organism)
	{
		return organism.Name.ToUpper();
	}

	public string GetNormalizedClass(T organism)
	{
		return organism.ClassName.ToUpper();
	}
}

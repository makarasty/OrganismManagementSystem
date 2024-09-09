public class PlantAccessor : OrganismAccessor<Plant>
{
	public Plant GetHighestPlant(Plant[] plants)
	{
		if (plants == null || plants.Length == 0)
		{
			throw new ArgumentException("Plant array should not be empty", nameof(plants));
		}

		Plant highest = plants[0];
		foreach (var plant in plants)
		{
			if (plant.Height > highest.Height)
				highest = plant;
		}

		return highest;
	}
}

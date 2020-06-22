using Zenject;

public class WeaponPlaceHolder : PlaceholderFactory<string, WeaponView>
{
}

public class WeaponFactory : IFactory<string, WeaponView>
{
	private readonly string WeaponPath = "WeaponPrefabs";
	private DiContainer diContainer;

	public WeaponFactory(DiContainer diContainer)
	{
		this.diContainer = diContainer;
	}

	public WeaponView Create(string param)
	{
		return diContainer.InstantiatePrefabResourceForComponent<WeaponView>($"{WeaponPath}/{param}");
	}
}

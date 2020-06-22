using System.Collections.Generic;

public interface IWeaponHolder
{
	void AddWeapon(IVehicleWeapon weapon);
	IVehicleWeapon GetWeaponByIndex(int index);
	int CountWeapons();
}

public class TankWeaponHolder : IWeaponHolder
{
	private WeaponPlaceHolder weaponFactory;
	private List<IVehicleWeapon> weapons = new List<IVehicleWeapon>();

	public void AddWeapon(IVehicleWeapon weapon)
	{
		weapons.Add(weapon);
	}

	public IVehicleWeapon GetWeaponByIndex(int index)
	{
		return weapons[index];
	}

	public int CountWeapons()
	{
		return weapons.Count;
	}
}



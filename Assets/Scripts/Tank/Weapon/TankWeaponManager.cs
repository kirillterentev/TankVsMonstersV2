public interface IWeaponManager
{
	void NextWeapon();
	void PrevWeapon();
	IVehicleWeapon CurrentWeapon();
}

public class TankWeaponManager : IWeaponManager
{
	private IWeaponHolder weaponHolder;
	private IVehicleWeapon[] weapons;
	private int currentWeaponIndex = 0;

	public TankWeaponManager(IWeaponHolder weaponHolder)
	{
		this.weaponHolder = weaponHolder;
	}

	public void NextWeapon()
	{
		if (++currentWeaponIndex >= weaponHolder.CountWeapons())
		{
			currentWeaponIndex = 0;
		}
	}

	public void PrevWeapon()
	{
		if (--currentWeaponIndex < 0)
		{
			currentWeaponIndex = weaponHolder.CountWeapons() - 1;
		}
	}

	public IVehicleWeapon CurrentWeapon()
	{
		return weaponHolder.GetWeaponByIndex(currentWeaponIndex);
	}
}



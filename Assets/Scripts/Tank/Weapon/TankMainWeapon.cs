
public interface IVehicleWeapon
{
	void Fire();
}

public class TankMainWeapon : IVehicleWeapon
{
	private IWeaponHolder weaponHolder;
	private WeaponPlaceHolder weaponFactory;
	private WeaponView view;

	public TankMainWeapon(WeaponView view, IWeaponHolder weaponHolder, TankView tankView)
	{
		this.view = weaponFactory.Create("MainWeapon");
		view.Transform.position = tankView.TurretSpawnPoint.position;
		this.weaponHolder = weaponHolder;
		weaponHolder.AddWeapon(this);
	}

	public void Fire()
	{
		
	}
}



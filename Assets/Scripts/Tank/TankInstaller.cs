using Zenject;

public class TankInstaller : MonoInstaller
{
	private readonly string TankDataPath = "VehiclesData/TankData";

	public override void InstallBindings()
	{
		Container.Bind<TankView>().FromComponentOnRoot().AsSingle().NonLazy();
		Container.Bind<TankData>().FromScriptableObjectResource(TankDataPath).AsSingle().NonLazy();
		Container.BindInterfacesAndSelfTo<TankInputSystem>().AsSingle().NonLazy();
		Container.Bind<IVehicleMovement>().To<TankMovementSystem>().AsSingle().NonLazy();

		Container.BindFactory<string, WeaponView, WeaponPlaceHolder>().FromFactory<WeaponFactory>().NonLazy();
		Container.Bind<IWeaponHolder>().To<TankWeaponHolder>().AsSingle().NonLazy();
		Container.Bind<IVehicleWeapon>().WithId("MainWeapon").To<TankMainWeapon>().AsSingle().NonLazy();
	}
}

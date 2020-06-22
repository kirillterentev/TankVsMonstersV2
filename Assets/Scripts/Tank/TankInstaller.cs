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
	}
}

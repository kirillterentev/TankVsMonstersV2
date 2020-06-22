using UnityEngine;

public interface IVehicleMovement
{
	void SetVelocity(Vector3 velocity);
	void SetRotation(Vector3 rotation);
}

public class TankMovementSystem : IVehicleMovement
{
	private TankView view;
	private TankData data;

	public TankMovementSystem(TankView view, TankData data)
	{
		this.view = view;
		this.data = data;
	}

	public void SetVelocity(Vector3 velocity)
	{
		view.Rigidbody.velocity = view.Transform.TransformDirection(velocity) * data.SpeedMovement;
	}

	public void SetRotation(Vector3 rotation)
	{
		view.Transform.rotation *= Quaternion.Euler(rotation * data.SpeedRotation);
	}
}

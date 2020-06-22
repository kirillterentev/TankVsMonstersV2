using UnityEngine;
using Zenject;

public class TankInputSystem : ITickable
{
	private IVehicleMovement movement;
	private Vector3 moveVector;
	private Vector3 rotVector;

	public TankInputSystem(IVehicleMovement movement)
	{
		this.movement = movement;
		moveVector = new Vector3();
		rotVector = new Vector3();
	}

	public void Tick()
	{
		moveVector.z = Input.GetAxis("Vertical");
		movement.SetVelocity(moveVector);

		rotVector.y = Input.GetAxis("Horizontal");
		movement.SetRotation(rotVector);
	}
}

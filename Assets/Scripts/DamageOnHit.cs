using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	#region Fields

	public int damage = 1;

	#endregion

	#region On collision enter - 2D
	/// <summary>
	/// Checks whether the game object has hit
	/// the player.
	/// </summary>
	void OnCollisionEnter2D (Collision2D collision)
    {
		var collidedObj = collision.gameObject;
		if (collidedObj.CompareTag("Player")) 
		{
			var healthComponent = 
				collidedObj.GetComponent<HealthController>();

			healthComponent.Damage(damage);
		}
	}
	#endregion
}

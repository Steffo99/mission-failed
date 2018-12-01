using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour 
{
	/// <summary>
	/// Velocità a cui far ruotare il braccio.
	/// </summary>
	public int speed = 1;

	/// <summary>
	/// Per testing.
	/// Determina se bisogna utilizzare 
	/// Quaternion.Slerp() o Quaternion.LookDirection().
	/// </summary>
	public bool useSlerp = false;

    void Update() 
	{
        //Trova la direzione tra il transform e il braccio
        Vector2 screenPosition = 
			Camera.main.WorldToScreenPoint(transform.position);
		
		Vector2 direction = 
			(Input.mousePosition - screenPosition) as Vector2;

		Vector3 lookDirection =
			new Vector3(direction.x, direction.y);

		/*
		 * In alternativa provare direttamente con 
		 * lookDirection = Input.mousePosition;
		 */
		if (useSlerp) 
		{
			Quaternion.Slerp (
				transform.rotation, 						// Rotazione iniziale
				Quaternion.LookRotation (lookDirection), 	// Rotazione finale
				speed * Time.deltaTime);					// Velocità dell'interpolazione
		}
		
		else // Questo dovrebbe bastare
			Quaternion.LookRotation (lookDirection);
    }
}

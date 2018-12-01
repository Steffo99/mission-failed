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
        Vector3 screenPosition = 
			Camera.main.WorldToScreenPoint(transform.position);
		
		Vector3 lookDirection = 
			(Vector3)(Input.mousePosition - screenPosition);

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

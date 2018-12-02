using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public string targetTag;
	public int damage = 1;

	void OnCollisionEnter2D (Collision2D collision)
    {
		GameObject collidedObj = collision.gameObject;
		if (collidedObj.CompareTag(targetTag)) 
		{
			HealthController healthController = collidedObj.GetComponent<HealthController>();
			healthController.Damage(damage);
		}
	}
}

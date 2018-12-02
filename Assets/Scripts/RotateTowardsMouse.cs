using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour 
{
    public float minAngle;
    public float maxAngle;

    void Update() 
	{
        Vector2 screenPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 lookDirection = ((Vector2)transform.position - screenPoint);
        transform.rotation = Quaternion.FromToRotation(Vector3.up, lookDirection);
    }
}

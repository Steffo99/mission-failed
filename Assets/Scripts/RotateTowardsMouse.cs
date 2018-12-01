using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour {
    //Circa qualcosa così

    void Update() {
        //Trova la direzione tra il transform e il braccio
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 direction = (Vector2)Input.mousePosition - screenPosition;
        //Cambia la rotazione dell'oggetto
        transform.rotation = Quaternion.identity;
    }
}

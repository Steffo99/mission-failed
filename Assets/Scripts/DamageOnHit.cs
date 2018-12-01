using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int damage = 1;

	// Quando il gameObject tocca qualcosa di solido...
	void OnCollisionEnter2D (Collision2D collision) {
		//Controlla se quello che ha colpito (collision.gameObject) è il giocatore (controlla tipo se il tag è "Player")
        //Se sì, trova il suo componente healthController e chiamane il metodo .Damage(int danni)
	}
}

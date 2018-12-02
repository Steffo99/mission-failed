using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 1f;

    private Vector3 startingScale;
    private new Rigidbody2D rigidbody;
    private Animator animator;

    private void Start()
    {
        startingScale = transform.localScale;
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate () {
        float horizontalMovement = 0;
        if(Input.GetKey(KeyCode.A)) {
            horizontalMovement -= movementSpeed;
            transform.localScale = new Vector3(-startingScale.x, startingScale.y, startingScale.z);
        }
        if(Input.GetKey(KeyCode.D))
        {
            horizontalMovement += movementSpeed;
            transform.localScale = new Vector3(startingScale.x, startingScale.y, startingScale.z);
        }
        animator.SetBool("isWalking", horizontalMovement != 0);
        rigidbody.velocity = new Vector3(horizontalMovement * movementSpeed, rigidbody.velocity.y);
	}

}

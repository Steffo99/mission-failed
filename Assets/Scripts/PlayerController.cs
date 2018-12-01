using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 1f;
    public float initialJumpForce = 10f;
    public float pushDownOnReleaseForce = 5f;
    public bool jumpAvailable = true;

    private new Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate () {
        float horizontalMovement = 0;
        if(Input.GetKey(KeyCode.A)) {
            horizontalMovement -= movementSpeed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            horizontalMovement += movementSpeed;
        }
        if(jumpAvailable && Input.GetKeyDown(KeyCode.W))
        {
            jumpAvailable = false;
            rigidbody.AddForce(Vector2.up * initialJumpForce);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            rigidbody.AddForce(Vector2.down * pushDownOnReleaseForce);
        }
        rigidbody.velocity = new Vector3(horizontalMovement * movementSpeed, rigidbody.velocity.y);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Terrain"))
        {
            jumpAvailable = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefaultJump : MonoBehaviour {

    public float initialJumpForce = 10f;
    public float pushDownOnReleaseForce = 5f;

    public bool jumpAvailable = true;
    private new Rigidbody2D rigidbody;

    void Start()
    {
        jumpAvailable = true;
        rigidbody = GetComponent<Rigidbody2D>();
    }

	void FixedUpdate () {
        if (jumpAvailable && Input.GetKeyDown(KeyCode.W))
        {
            jumpAvailable = false;
            rigidbody.AddForce(Vector2.up * initialJumpForce);
        }
        if (!jumpAvailable && Input.GetKeyUp(KeyCode.W))
        {
            rigidbody.AddForce(Vector2.down * pushDownOnReleaseForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            jumpAvailable = true;
        }
    }
}

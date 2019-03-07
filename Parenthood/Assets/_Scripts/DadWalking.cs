using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadWalking : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;
    private Rigidbody2D rigidBody2D;

    Animator anim;

    void Start () {
        rigidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	

	void Update () {
		
	}

    private void FixedUpdate()
    {

        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(move));

        rigidBody2D.velocity = new Vector2(move * maxSpeed, rigidBody2D.velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale;
    }
}

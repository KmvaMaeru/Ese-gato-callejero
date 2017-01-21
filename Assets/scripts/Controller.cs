using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Obsoleto

public class Controller : MonoBehaviour {

    public float moveSpeed;
	private float moveVelocity;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

	public Animator anim;


	// Use this for initialization
	void start() {
	anim = GetComponent<Animator>();

    }
        void FixedUpdate() {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


    }

	// Update is called once per frame
	void Update () {

	if(grounded)
	anim.SetBool("Grounded", true);
	if(!grounded)
	anim.SetBool("Grounded", false);



        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

	moveVelocity = 0f;

         if(Input.GetKey(KeyCode.D))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	moveVelocity = moveSpeed;


        }



        if(Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
	moveVelocity = -moveSpeed;

	}

	GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

	anim.SetFloat("Speed", Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x));

	if(GetComponent<Rigidbody2D>().velocity.x > 0)
	transform.localScale = new Vector3(5f, 5f, 1f);

	else if(GetComponent<Rigidbody2D>().velocity.x < 0)
	transform.localScale = new Vector3(-5f, 5f, 1f);


	}
}

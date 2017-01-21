using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

    public float moveSpeed;
    public float moveVelocity;
    public float jumpHeight;
	private DosPuntos wallStick;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

	public float knockback;
	public float knockbackLength;
	public float knockbackCount;
	public bool knockFromRight;

	public Animator anim;

	public bool  canMove;


	// Use this for initialization
	void start() {
	anim = GetComponent<Animator>();
	wallStick = GetComponent<DosPuntos>();

    }
        void FixedUpdate() {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


    }

	// Update is called once per frame
	void Update () {

	if(!canMove)
	{
		return;
	}
        //Determina que pasa cuando esta en el puso y cuando no para animaciones
	if(grounded)
	anim.SetBool("Grounded", true);
	if(!grounded)
	anim.SetBool("Grounded", false);


		//Determina que si presionas espacio salta
        if(Input.GetButtonDown ("Jump") && grounded)
        {
	         Jump();
        }

	//La velocidad a la que va es igual a la rápides que determines por el lado al que lo mandes

         moveVelocity = moveSpeed * Input.GetAxisRaw("Horizontal");

         //Determina como sera el empuje de ser herido
  if(knockbackCount <= 0)
	{

	GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
	} else {
		if(knockFromRight)
			GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
		if(!knockFromRight)
			GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);
		knockbackCount -= Time.deltaTime;
	}

	anim.SetFloat("Speed", Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x));

  //Dice a que lado estará el sprite
	if(GetComponent<Rigidbody2D>().velocity.x > 0)
	transform.localScale = new Vector3(5f, 5f, 1f);

	else if(GetComponent<Rigidbody2D>().velocity.x < 0)
	transform.localScale = new Vector3(-5f, 5f, 1f);


	}


  //Dice que es el salto
	public void Jump()
	{
	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}

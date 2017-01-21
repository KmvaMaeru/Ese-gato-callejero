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
        
	if(grounded)
	anim.SetBool("Grounded", true);
	if(!grounded)
	anim.SetBool("Grounded", false);

     
		
        if(Input.GetButtonDown ("Jump") && grounded)
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	Jump();
        }
        
	//moveVelocity = 0f;
         
         moveVelocity = moveSpeed * Input.GetAxisRaw("Horizontal");
	
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

	if(GetComponent<Rigidbody2D>().velocity.x > 0)
	transform.localScale = new Vector3(5f, 5f, 1f);

	else if(GetComponent<Rigidbody2D>().velocity.x < 0)
	transform.localScale = new Vector3(-5f, 5f, 1f);
	
	        
	}

	

	public void Jump()
	{
	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}

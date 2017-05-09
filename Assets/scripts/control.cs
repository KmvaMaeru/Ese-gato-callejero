using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
  //Valores de las acciones
    public float moveSpeed;
    public float initialSpeed;
    public float moveVelocity;
    public float runMultiplier;
    public float jumpHeight;
	private DosPuntos wallStick;
  //Deteccion del piso
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    //Valores del empuje de los enemigos
	public float knockback;
	public float knockbackLength;
	public float knockbackCount;
	public bool knockFromRight;
  //Detecta el Animador
	public Animator anim;
  //Para que no se pueda mover el jugador
	public bool canMove;



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

#if UNITY_STANDALONE 
		//Determina que si presionas espacio salta
        if(Input.GetButtonDown ("Jump"))
        {
	         Jump();
        }



	//Llama a la funcion de correr

  if(Input.GetButtonDown("Fire1"))
  {
    //moveSpeed = runMultiplier;
    Dash();
  }
  if(Input.GetButtonUp("Fire1"))
  {
    //moveSpeed = initialSpeed;
    ResetDash();
  }



   //moveVelocity = moveSpeed * Input.GetAxisRaw("Horizontal");
   Move (Input.GetAxisRaw("Horizontal"));


#endif
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
  public void Move (float moveInput)
  {
    moveVelocity = moveSpeed * moveInput;
  }
  public void Dash ()
  {
    moveSpeed = runMultiplier;
  }
  public void ResetDash ()
  {
    moveSpeed = initialSpeed;
  }

  //Dice que es el salto
	public void Jump()
	{
    if(grounded){
	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
}
	}
}

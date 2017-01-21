using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DosPuntos : MonoBehaviour {

    public float jumpHeight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool wallStick;


	public Animator anim;

	// Use this for initialization
	void start() {
	anim = GetComponent<Animator>();


    }
        //Que esm pegarse al muro
        void FixedUpdate() {

        wallStick = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);


    }


	// Update is called once per frame
	void Update () {



    //Determina la animación
  if(wallStick)
	anim.SetBool("Friction", true);
	if(!wallStick)
	anim.SetBool("Friction", false);



  //Las condiciones para poder saltar
  if(Input.GetKeyDown(KeyCode.Space)&& wallStick)
        {

		{
		Jump();
		}

    //Dice a que lado mira el gato
  if(GetComponent<Rigidbody2D>().velocity.x > 0)
	transform.localScale = new Vector3(5f, 5f, 1f);

	else if(GetComponent<Rigidbody2D>().velocity.x < 0)
	transform.localScale = new Vector3(-5f, 5f, 1f);


	}

	}
  //Dice que es Jump
  public void Jump()
	{


	GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);


	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piranna : MonoBehaviour {

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	public bool playerInRange;
	public LayerMask playerLayer;
	public float playerRange;
	public float jumpHeight;

	// Use this for initialization
	void Start () {
	}
	void FixedUpdate() {

	grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);


}

	// Update is called once per frame
	void Update () {
		playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);
		if(playerInRange && grounded)
		{
			Jump();
		}

	}
		void OnDrawGizmosSelected(){

			Gizmos.DrawSphere(transform.position, playerRange);


		}


	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}

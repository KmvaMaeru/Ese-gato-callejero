using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAnimation : MonoBehaviour {

	public GameObject objetive;
	public float moveSpeed;
	public bool canFly;
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

	}

	void Update (){
		if(canFly)
		{
		transform.position = Vector3.MoveTowards(transform.position, objetive.transform.position, moveSpeed * Time.deltaTime);
		anim.SetBool("Current", true);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		//Detecta al jugador pasar por el Checkpoint
		if(other.name == "gato2")
		 {
			 canFly = true;
		 }
}
}

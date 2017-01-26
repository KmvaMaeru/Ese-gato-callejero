using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonMove : MonoBehaviour {

	private control thePlayer;
	public float moveSpeed;
	public float playerRange;
	public LayerMask playerLayer;
	public bool playerInRange;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<control>();

	}

	// Update is called once per frame
	void Update () {

		playerInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);
		if(playerInRange)
		{
			transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, moveSpeed * Time.deltaTime);

		}

	}

	void OnDrawGizmosSelected(){

		Gizmos.DrawSphere(transform.position, playerRange);


	}

	}

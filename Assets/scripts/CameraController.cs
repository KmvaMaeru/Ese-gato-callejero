using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public control player;

	public bool isFollowing;

	public float xOffset;
	public float yOffset;
	public float zOffset;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<control>();
		isFollowing = true;
	}

	// Update is called once per frame
	void Update () {
		//Para que la cámara siga al jugador
		if(isFollowing)
			transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, player.transform.position.z + zOffset);

	}
}

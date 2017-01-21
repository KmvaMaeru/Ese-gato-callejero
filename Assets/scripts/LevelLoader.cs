using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	private bool playerInZone;

	public string levelToLoad;

	public string levelTag;

	// Use this for initialization
	void Start () {
		playerInZone = false;		
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButton("Vertical") && playerInZone)
	{
		PlayerPrefs.SetInt (levelTag, 1);
		Application.LoadLevelAsync(levelToLoad);
	}
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
	if(other.name == "gato2")
	{		

	playerInZone = true;
	}
	}

	void OnTriggerExit2D(Collider2D other)
	{
	if(other.name == "gato2")
	{		

	playerInZone = false;
	}
	}
}

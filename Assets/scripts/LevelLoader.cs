using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	private bool playerInZone;

	public string levelToLoad;

	public string levelTag;

	// Use this for initialization
	void Start () {
		//Dice si el jugador llego al final o no
		playerInZone = false;

	}
	IEnumerator ChangeLevel()
	{
	 float fadeTime = GameObject.Find("MainHUD").GetComponent<Shading>().BeginFade(1);
	 yield return new WaitForSeconds(fadeTime);
	 Application.LoadLevelAsync(levelToLoad);
	}
	// Update is called once per frame
	void Update () {

		//Desbloquea el siguiente nivel y lleva al jugador a otro nivel
	if(Input.GetButton("Vertical") && playerInZone)
	{
		PlayerPrefs.SetInt (levelTag, 1);
		StartCoroutine(ChangeLevel());
	}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//Dice cuando el juagdor esta al final del nivel
		if(other.name == "gato2")
		{

			playerInZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		//Dice cuando el juagdor no esta al final del nivel
		if(other.name == "gato2")
		{

			playerInZone = false;
		}
	}
}

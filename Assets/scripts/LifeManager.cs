using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {

	//public int startingLives;
	private int lifeCounter;

	private Text theText;

	public GameObject gameOverScreen;
	public control player;

	public string mainMenu;

	public float waitAfterGameOver;

	// Use this for initialization
	void Start () {
		theText = GetComponent<Text>();

		lifeCounter = PlayerPrefs.GetInt("PlayerCurrentLives");

		player = FindObjectOfType<control>();

	}

	// Update is called once per frame
	void Update () {
		//Que pasa si no quedan vidas
		if(lifeCounter < 1)
	{
		gameOverScreen.SetActive(true);
		player.gameObject.SetActive(false);
	}


		//Que va a decir el contador de vidas
		theText.text = "x " + lifeCounter;

		//Si la pantalla de GameOver esta activa
		if(gameOverScreen.activeSelf)
		{
			waitAfterGameOver -= Time.deltaTime;
		}
		//Si acabó el tiempo de espera de la pantalla de GameOver
		if(waitAfterGameOver < 0)
		{
			Application.LoadLevel(mainMenu);
		}

	}

	//Que pasa cuando tomas una vida
	public void GiveLife()
	{
		lifeCounter++;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}
	//Que pasa si eres herido
	public void TakeLife()
	{
		lifeCounter--;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}
}

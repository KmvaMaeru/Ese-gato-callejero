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
		if(lifeCounter < 1)
	{
		gameOverScreen.SetActive(true);
		player.gameObject.SetActive(false);
	}


		theText.text = "x " + lifeCounter;

		if(gameOverScreen.activeSelf)
		{
			waitAfterGameOver -= Time.deltaTime;
		}
		if(waitAfterGameOver < 0)
		{
			Application.LoadLevel(mainMenu);
		}
		
	}

	public void GiveLife()
	{
		lifeCounter++;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}
	
	public void TakeLife()
	{
		lifeCounter--;
		PlayerPrefs.SetInt ("PlayerCurrentLives", lifeCounter);
	}
}

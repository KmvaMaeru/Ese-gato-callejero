using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {

	public string levelSelect;

	public string mainMenu;

	public bool isPaused;

	public GameObject pauseMenuCanvas;




	// Update is called once per frame
	void Update () {
		//Si el juego esta pausado
		if(isPaused)
		{
			pauseMenuCanvas.SetActive(true);
			Time.timeScale = 0f;
		} else {
			pauseMenuCanvas.SetActive(false);
			Time.timeScale = 1f;
		}
			//Si de presiona Escape
			if(Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}
		}

	//Que hace el boton Resume
	public void Resume()
	{
		isPaused = false;
	}
	//Que hace el boton LevelSelect
	public void LevelSelect()
	{
		Application.LoadLevel (levelSelect);
	}
	//Que hace el boton Quit
	public void Quit()
	{
		Application.LoadLevel (mainMenu);
	}


}

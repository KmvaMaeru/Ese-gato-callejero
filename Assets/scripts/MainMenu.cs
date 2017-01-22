using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public string startLevel;

	public string levelSelect;

	public int playerLives;

	public string level1Tag;

	public string controlScreen;

	//Que hace el boton NewGame
	public void NewGame()
	{
		PlayerPrefs.SetInt(level1Tag, 1);
		Application.LoadLevel (startLevel);

		PlayerPrefs.SetInt ("PlayerCurrentLives", playerLives);
		PlayerPrefs.SetInt ("CurrentScore", 0);

	}
	//Que hace el boton LevelSelect
	public void LevelSelect()
	{
		PlayerPrefs.SetInt ("PlayerCurrentLives", playerLives);
		PlayerPrefs.SetInt ("CurrentScore", 0);
		PlayerPrefs.SetInt(level1Tag, 1);
		Application.LoadLevel (levelSelect);
	}

	//Que hace el boton QuitGame
	public void QuitGame()
	{
		Debug.Log("Salí del juego");
		Application.Quit();

	}
	//Carga la imagen de los controles
	public void Controles()
	{
		Application.LoadLevel (controlScreen);
	}


}

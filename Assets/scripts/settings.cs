using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour {

	public string generalScreen;
	public string controlScreen;
	public string mainMenu;
	public Button noActivado;

	void Start()
	{
		noActivado.interactable = false;
	}

	public void GeneralScreen()
	{
		Application.LoadLevel (generalScreen);
	}

	public void ControlScreen()
	{
		Application.LoadLevel (controlScreen);
	}

	public void BackToMenu()
	{
		Application.LoadLevel (mainMenu);
	}



}

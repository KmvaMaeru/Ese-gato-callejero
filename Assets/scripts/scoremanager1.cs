using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager1 : MonoBehaviour {

	public static int score;

	Text text;

	void Start()
	{
		text = GetComponent<Text>();

		score = PlayerPrefs.GetInt("CurrentScore");
	}

	void Update()
	{
		//Si por alguna razón el record es menor a 0
		if (score < 0)
		score = 0;
		//Que va a decir el texto
	text.text = "" + score;
	}
	//Que pasa si los puntos de agregan
	public static void AddPoints (int pointsToAdd)
	{
		score+= pointsToAdd;
		PlayerPrefs.SetInt ("CurrentScore", score);
	}
	//Resetea el record
	public static void Reset()
	{
		score = 0;
		PlayerPrefs.SetInt ("CurrentScore", score);
	}
}

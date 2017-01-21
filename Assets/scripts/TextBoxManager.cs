using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	public control player;

	public bool isActive;

	public bool stopPlayerMovement;

	// Use this for initialization
	void Start () {

		player = FindObjectOfType<control>();
		//Importa el texto de un archivo externo
		if(textFile != null)
		{
			textLines = (textFile.text.Split('\n'));
		}

		if(endAtLine == 0)
		{
			endAtLine = textLines.Length - 1;
		}
		//QUe pasa si hay texto activo
		if(isActive)
		{
			EnableTextBox();
		}else
		{
			DisableTextBox();
		}
	}
	void Update()
	{
		//QUe pasa si no hay texto activo

		if(!isActive)
		{
			return;
		}
		theText.text = textLines[currentLine];
		//Si presionas enter
		if(Input.GetKeyDown(KeyCode.Return))
		{
			currentLine += 1;
		}
		//Indica el final del dialogo
		if(currentLine > endAtLine)
		{
			DisableTextBox();
		}


	}
	//Activa la caja de texto
	public void EnableTextBox()
	{
		textBox.SetActive(true);
		isActive = true;

		if(stopPlayerMovement)
		{
			player.canMove = false;
		}
	}
	//Desactiva la caja de texto
	public void DisableTextBox()
	{
		textBox.SetActive(false);
		isActive = false;

		player.canMove = true;

	}
	//Recarga las funciones
	public void ReloadScript(TextAsset theText)
	{
		if(theText !=null)
		{
			textLines = new string[1];
			textLines = (theText.text.Split('\n'));

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public TextBoxManager theTextBox;

	public bool requireButtonPress;
	private bool waitForPress;

	public bool destroyWhenActivated;

	// Use this for initialization
	void Start () {
		theTextBox = FindObjectOfType<TextBoxManager>();

	}

	// Update is called once per frame
	void Update () {

		//Para iniciar un texto con tecla
		if(waitForPress && Input.GetKeyDown(KeyCode.E))
		{

			theTextBox.ReloadScript(theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.EnableTextBox();

			if(destroyWhenActivated)
			{
				Destroy(gameObject);
			}

		}

	}

	//Para iniciar un texto cuando este cerca del NPC
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "gato2")
		{
			if(requireButtonPress)
			{
				waitForPress = true;
				return;
			}


			theTextBox.ReloadScript(theText);
			theTextBox.currentLine = startLine;
			theTextBox.endAtLine = endLine;
			theTextBox.EnableTextBox();

			if(destroyWhenActivated)
			{
				Destroy(gameObject);
			}
		}
	}

	//Revisa si el jugador esta en el área
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.name == "gato2")
		{
			waitForPress = false;
		}
	}
}

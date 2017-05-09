using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipButton : MonoBehaviour {

	public string theLevel;

	public void SkipIntro()
	{
		Application.LoadLevel(theLevel);
	}
}

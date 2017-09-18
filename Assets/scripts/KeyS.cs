using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyS : MonoBehaviour {

	public string levelBack;

	public void back ()
	{
		Application.LoadLevel (levelBack);
	}

}

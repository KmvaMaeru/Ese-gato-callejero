using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBack : MonoBehaviour {

	public string levelToLoad;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Cancel"))
		{
			Application.LoadLevelAsync(levelToLoad);
		}

	}
}

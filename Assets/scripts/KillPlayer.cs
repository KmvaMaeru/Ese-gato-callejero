using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Obsoleto

public class KillPlayer : MonoBehaviour {

	public LevelManager levelManager;


	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
            if(other.name == "gato2")
               {
                levelManager.RespawnPlayer();
               }
    }
}

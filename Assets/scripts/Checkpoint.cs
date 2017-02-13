using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

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
						//Detecta al jugador pasar por el Checkpoint
            if(other.name == "gato2")
               {
                levelManager.currentCheckpoint = gameObject;
               }
    }
}

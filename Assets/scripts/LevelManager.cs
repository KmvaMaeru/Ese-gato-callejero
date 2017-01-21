using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
    public GameObject currentCheckpoint;
    
    private control player;
    
	public int pointPenaltyOnDeath;

	public HealthManager healthManager;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<control>();
		healthManager = FindObjectOfType<HealthManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void RespawnPlayer()
    {

	scoremanager1.AddPoints(-pointPenaltyOnDeath);
        Debug.Log ("Player Respawn");
        player.transform.position = currentCheckpoint.transform.position;
	healthManager.FullHealth();
	healthManager.isDead = false;
    }
}

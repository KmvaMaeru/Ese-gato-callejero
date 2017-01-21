using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {
	public int maxPlayerHealth;

	public static int playerHealth;


	Text text;

	private LevelManager levelManager;

	public bool isDead;

	private LifeManager lifeSystem;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();

		playerHealth = maxPlayerHealth;

		levelManager = FindObjectOfType<LevelManager>();
		lifeSystem = FindObjectOfType<LifeManager>();
	isDead = false;



	}

	// Update is called once per frame
	void Update () {
		//Por si la vida es igual a cero por alguna razon
		if(playerHealth <= 0 && !isDead)
	{
		playerHealth = 0;
		isDead = true;
		levelManager.RespawnPlayer();

		lifeSystem.TakeLife();
	}

	//Que dirá el texto
	text.text = "" + playerHealth;

	}

	//Llama a las finciones de otros scripts
	public static void HurtPlayer(int damageToGive)
	{
		playerHealth -= damageToGive;
	}

	public void FullHealth()
	{
		playerHealth = maxPlayerHealth;
	}
}

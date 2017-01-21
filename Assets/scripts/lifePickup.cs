using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Para dar una vida cuando se pase sobre ella
public class lifePickup : MonoBehaviour {

	private LifeManager lifeSystem;

	// Use this for initialization
	void Start () {
		lifeSystem = FindObjectOfType<LifeManager>();
	}

	void OnTriggerEnter2D(Collider2D other)
		{
			if (other.name == "gato2")
			{
				lifeSystem.GiveLife();
				Destroy(gameObject);
			}
		}
}

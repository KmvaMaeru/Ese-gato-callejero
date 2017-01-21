﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	public int pointsToAdd;

	//Detecta al jugador en el área del coleccionable
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.GetComponent<control>() == null)
		return;

		scoremanager1.AddPoints(pointsToAdd);

		Destroy (gameObject);
	}
}

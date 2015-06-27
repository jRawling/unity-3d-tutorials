﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour 
{
	public GameObject asteroidExplosion;
	public GameObject playerExplosion;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Boundary")  { return; }
		Instantiate (asteroidExplosion, transform.position, transform.rotation);
		if (other.tag == "Player") 
		{
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		}
		Destroy(other.gameObject);
		Destroy (gameObject);
	}
}
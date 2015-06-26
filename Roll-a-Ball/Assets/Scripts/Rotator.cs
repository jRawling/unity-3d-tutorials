using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	private Vector3 rotation;

	void Start()
	{
		rotation = new Vector3 (15, 30, 45);
	}

	void Update()
	{
		transform.Rotate (rotation * Time.deltaTime);
	}
}
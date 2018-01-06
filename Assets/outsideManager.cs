using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outsideManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collidedObject)
	{
		Debug.Log ("Collison");
		Debug.Log(collidedObject.name);
		Destroy(collidedObject.gameObject);
		
	}
}

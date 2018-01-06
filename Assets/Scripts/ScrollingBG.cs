using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour {

	public float Speed =0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 direction  = new Vector2(	Time.time*Speed,0);
	
		GetComponent<Renderer>().material.mainTextureOffset= direction;
	}
}

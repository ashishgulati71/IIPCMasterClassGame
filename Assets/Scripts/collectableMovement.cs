using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableMovement : MonoBehaviour {
	public Vector2 speed =new Vector2(-2.0f,0);
	// Use this for initialization
	float height =0;
	void Start () {
		height=Random.Range(-2,4);
		transform.position= new Vector3 (transform.position.x,height,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity=speed;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treemovement : MonoBehaviour {
	public Vector2 speed =new Vector2(-1.0f,0);
	float heightRatio =0;
	void Start () {
		heightRatio=Random.Range(0.60f,1.36f);
		//print (heightRatio);
		transform.position= new Vector3 (transform.position.x,-4,transform.position.z);
		transform.localScale = new Vector3(heightRatio,heightRatio,transform.localScale.z) ;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity=speed;
	}
}

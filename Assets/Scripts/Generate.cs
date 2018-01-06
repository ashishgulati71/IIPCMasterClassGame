using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
	public GameObject coin;
	public GameObject tree;
	// Use this for initialization
	void Start () {
		InvokeRepeating(  "GenerateCoin",2.0f,2.0f);
		InvokeRepeating(  "GenerateTree",2.0f,5.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void GenerateCoin(){
		Instantiate(coin);
	}
	void GenerateTree(){
		Instantiate(tree);
	}
}

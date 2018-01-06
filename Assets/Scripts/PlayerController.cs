using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Vector2 jumpForce = new Vector2 (0,50f);
	int Score=0;
	AudioSource Coinaudio, gameoverAudio, ScriptHolderaudio;
	public GameObject GameoverObject;
	public GameObject ScriptHolderObject;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		Coinaudio=GetComponent<AudioSource>();
		gameoverAudio=GameoverObject.GetComponent<AudioSource>();
		ScriptHolderaudio=ScriptHolderObject.GetComponent<AudioSource>();
		//scoreText= GetComponent<Text>();
	}
	 

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("space") || Input.touchCount == 1)
		{
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}

	}

	void OnTriggerEnter2D(Collider2D colObject)
	{
		Debug.Log ("Collison");
		if(colObject.gameObject.CompareTag("Enemy"))
		   {
			Destroy(gameObject);
			print ("enemy collided + game over");
			//play gameover
			gameoverAudio.Play();			
			ScriptHolderaudio.Stop();
		}
		else if(colObject.gameObject.CompareTag("Collectable"))
		        {
			Destroy(colObject.gameObject);
			//sound
			Coinaudio.Play();
			scoreText.text="Score : "+ ++Score;
			print ("Score:"+ Score);
		}

	}

}

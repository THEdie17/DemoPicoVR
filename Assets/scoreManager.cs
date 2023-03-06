using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour {

	public static scoreManager instance;

	public int score = 0;
	public TextMesh textScore;
	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = ""+score;
	}

	public void incrementar(){
		score = score + 1;
	}
}

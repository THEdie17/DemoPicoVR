using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeManager : MonoBehaviour {

	public static lifeManager instance;

	public int life = 5;
	public TextMesh textLife;
	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh>().text = ""+life;

		if (life < 0){
			GetComponent<TextMesh>().text = "dead";
			Application.Quit();
		}
	}

	public void restar(){
		life = life - 1;
	}
}

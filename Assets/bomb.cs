using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour {

	public static bomb instance;
	public lifeManager lifes;
	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	private void  OnTriggerEnter(Collider other) {

		if (other.CompareTag("espasa") && gameObject.CompareTag("bomb")) 
		{
			Debug.Log ("BOMB");
			lifeManager.instance.restar();
			Destroy(gameObject);
		}
	}
}

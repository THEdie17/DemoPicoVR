using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour {
	
	public static apple instance;
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

		if (other.CompareTag("espasa") && gameObject.CompareTag("fruit"))
		{
			Debug.Log ("COLLISION");
			scoreManager.instance.incrementar();
			Destroy(gameObject);
		}
	}
}

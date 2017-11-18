using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "GroundTag" || other.gameObject.tag == "BlockTag") {
			GetComponent<AudioSource> ().Play();
			Debug.Log ("a");
		}
	}
}

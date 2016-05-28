using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OntriggerEnter (Collider other) {
		if (other.name == "Player"){
			Debug.Log ("Dead");
			Destroy (other);
		}

	}
}

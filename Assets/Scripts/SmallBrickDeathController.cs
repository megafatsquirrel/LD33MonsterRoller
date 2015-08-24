using UnityEngine;
using System.Collections;

public class SmallBrickDeathController : MonoBehaviour {

	public GameObject remains;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) { 

		if ( other.tag == "Player" ) {

			Instantiate( remains, transform.position, transform.rotation );
			Destroy( gameObject );
			ScoreManager.score += 100;

		}

	}
}

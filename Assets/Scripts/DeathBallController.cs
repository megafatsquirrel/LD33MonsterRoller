using UnityEngine;
using System.Collections;

public class DeathBallController : MonoBehaviour {


	Rigidbody rb;
	public static bool ballRolling = false;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	public void FireBallOfDeath () {

		if ( !GameController.gameOver && !ballRolling) {

			ballRolling = true;

			// TODO change this to accel over time instead of a impulse
			rb.velocity = new Vector3( 0, 0, 25.0f );

			BallCountManager.ballCount--;

		}

	}
}

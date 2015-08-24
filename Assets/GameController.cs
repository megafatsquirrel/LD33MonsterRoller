using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public static bool gameOver = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

		if ( BallCountManager.ballCount <= 0 ) {
			
			gameOver = true;
			
		}

		// Reset game
		if ( gameOver && Input.GetKeyUp( KeyCode.T ) ) {

			BallCountManager.ballCount = 3;
			ScoreManager.score = 0;
			gameOver = false;

			setupShot();

		}

	}

	public void setupShot() {

		if ( !gameOver ) {

			GameObject slope = GameObject.FindGameObjectWithTag("Slope");
			slope.transform.position = new Vector3( 120f, 60f, -37f );
			
			GameObject player = GameObject.FindGameObjectWithTag("Player");

			Rigidbody rb = player.GetComponent<Rigidbody>();
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.rotation = Quaternion.identity;

			player.transform.position = new Vector3( 0f, 36f, -120f );
			DeathBallController.ballRolling = false;

		}


	}
}

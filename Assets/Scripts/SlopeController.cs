using UnityEngine;
using System.Collections;

public class SlopeController : MonoBehaviour {

	public float maxLeft;
	public float maxRight;
	public float movementInterval;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {



	}

	public void moveSlopeLeft () {

		if ( transform.position.x > maxLeft && !DeathBallController.ballRolling ) {

			float newX = transform.position.x - movementInterval;
			transform.position = new Vector3( newX, transform.position.y, transform.position.z );

			GameObject player = GameObject.FindGameObjectWithTag("Player");
			float newPlayerX = player.transform.position.x - movementInterval;
			player.transform.position = new Vector3( newPlayerX, player.transform.position.y, player.transform.position.z );

		}

	}


	public void moveSlopeRight () {

		if ( transform.position.x < maxRight && !DeathBallController.ballRolling ) {
			
			float newX = transform.position.x + movementInterval;
			transform.position = new Vector3( newX, transform.position.y, transform.position.z );

			GameObject player = GameObject.FindGameObjectWithTag("Player");
			float newPlayerX = player.transform.position.x + movementInterval;
			player.transform.position = new Vector3( newPlayerX, player.transform.position.y, player.transform.position.z );

		}

	}

}

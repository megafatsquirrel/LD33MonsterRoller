using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;
	Vector3 startingLocation;

	bool cameraReset = false;

	// Use this for initialization
	void Start () {

		offset = transform.position - target.position;
		startingLocation = transform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if ( !cameraReset ) {

			Vector3 targetCamPos = target.position + offset;
			transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime );
			transform.rotation = Quaternion.Euler( 50f, 0f, 0f );

		}

		if ( Input.GetKeyDown(KeyCode.R) ) {

			cameraReset = true;
			transform.position = startingLocation;

		}

	}
}

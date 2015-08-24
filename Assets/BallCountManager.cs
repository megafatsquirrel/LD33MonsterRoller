using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallCountManager : MonoBehaviour {

	public static int ballCount = 3;
	Text text;
	
	// Use this for initialization
	void Start () {
		
		text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Ball Count: " + ballCount;
		
	}
}

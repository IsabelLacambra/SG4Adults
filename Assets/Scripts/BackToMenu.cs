using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {

	float timeRemaining = 7; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;

		if(timeRemaining <= 0.0f){
			Application.LoadLevel ("Scene01");
		}


	}
}

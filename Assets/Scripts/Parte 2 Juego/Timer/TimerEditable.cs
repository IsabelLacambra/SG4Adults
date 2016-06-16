using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerEditable : MonoBehaviour {
	/*Clase referente al timmer que comienza cuando aparece la pregunta y las respuestas, 
	 * este timer se puede editar, se pueden sumar segundos si la regunta es dificil*/


	public float timeRemaining = 30;  
	Text text;

	public bool comenzar = false;


	void Awake () {
		text = GetComponent<Text> ();


	}

	// Update is called once per frame
	void Update () {


		if (comenzar) {
			if(timeRemaining == 0){

			}

			timeRemaining -= Time.deltaTime;
			
			text.text = "" + (int)timeRemaining;
		}
	}



//*********************************************************************************************************************
//	GETTERS Y SETTERS

	public bool Comenzar{
		get{ return comenzar;}
		set { comenzar = value;}	
	}

	public float TimeRemaining{
		get{ return timeRemaining;}
		set { timeRemaining = value;}	
	}

}

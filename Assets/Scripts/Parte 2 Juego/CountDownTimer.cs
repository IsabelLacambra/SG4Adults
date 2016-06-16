using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountDownTimer : MonoBehaviour {

	/*Clase con la que controlamos el timer inicial desde 5 hasta 0 y luego aparece la pregunta y las prespuestas*/



	float timeRemaining = 5;  //variable que hace referencia a la cuenta atras, es 5 pero lo que hago es mostrar un numero menos, cuando es 5 muestro 4, cuando es 4 muestro 3 por pantalla
	//para que asi luego al poner GO me quede un segundo en el que decir que se borre lo que hay escrito


	float aux;// variable auxiliar que tiene lo que se muestra por pantaalla
	Text text;



	public static bool timeisout= false; //para controlar cuando acaba el timer y puedo imprimir la pregunta

	public GameObject Pregunta;

	// Use this for initialization
	void Awake () {

		text = GetComponent<Text> ();
	}


	// Update is called once per frame
	void Update () {

		if (timeisout != true) {

			timeRemaining -= Time.deltaTime;
			aux = timeRemaining - 1; //resto uno al timer
			text.text = "" + (int)aux;
			
			if (timeRemaining < 2 && timeRemaining>1) { //cuando quedan 2 segundos -> GO
				text.text = "GO!" ;
				Pregunta.SetActive (true);
			}
			if (timeRemaining < 1) {//pasado un segundo despues de poner GO, lo borro
				text.text = " " ;
				timeisout = true;
			}
		}

	}

	
	//***********************************************************************************************************************************
	
	//GETTERS Y SETTERS
	
	public float CountDownTime{
		get{ return timeRemaining;}
		set { timeRemaining = value;}	
	}
	
	public bool CountDownTimeBool{
		get{ return timeisout;}
		set { timeisout = value;}	
	}




}
using UnityEngine;
using System.Collections;

public class MASTiempo : MonoBehaviour {


	/*BOTON DE MAS TIEMPO */


	public GameObject tiempoRestante;
	TimerEditable miTiempo;


	void Awake () {
		
		// inicializo las vaiables al comenzar la jugada
		miTiempo = (TimerEditable)tiempoRestante.GetComponent (typeof(TimerEditable));
	}
	
	public void pressedButton(){
		if (miTiempo.TimeRemaining > 5) {
			miTiempo.TimeRemaining+=10;

		}
	}
}

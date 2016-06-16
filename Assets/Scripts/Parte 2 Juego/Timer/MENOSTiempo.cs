using UnityEngine;
using System.Collections;

public class MENOSTiempo : MonoBehaviour {

	public GameObject tiempoRestante;
	TimerEditable miTiempo;
	
	
	void Awake () {
		
		// inicializo las vaiables al comenzar la jugada
		miTiempo = (TimerEditable)tiempoRestante.GetComponent (typeof(TimerEditable));
	}
	
	public void pressedButton(){
		if (miTiempo.TimeRemaining > 20) {
			miTiempo.TimeRemaining-=10;
			
		}
	}
}

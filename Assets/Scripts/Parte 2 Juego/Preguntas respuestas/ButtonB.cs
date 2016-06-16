using UnityEngine;
using System.Collections;

public class ButtonB : MonoBehaviour {

	/*CON ESTA CLASE LO QUE HAGO ES COMPROBAR SI LA OPCION SELECCIONADA ES LA CORRECTA O NO*/

	public GameObject respB;
	ClsRespB miRespB;


	//con esta variable marcare que ya ha contestado a la pregunta una vez se clicke un boton
	public GameObject haContestado;
	SolucionControlador miHaContestado;
	
	//con esta variable marcare que cual es la solucion a la pregunta, si verdadera o falsa
	public GameObject solucion;
	SolucionControlador miSolucion;
	
	


	void Awake () {
		
		// inicializo las vaiables al comenzar la jugada
		miRespB = (ClsRespB)respB.GetComponent (typeof(ClsRespB));
		miHaContestado = (SolucionControlador)haContestado.GetComponent (typeof(SolucionControlador));
		miSolucion = (SolucionControlador)solucion.GetComponent (typeof(SolucionControlador));
	}


	public void pressedButton(){
		if (miRespB.EsCorrecta) 
		{
			miSolucion.Solucion = true;
			miHaContestado.HaContestado= true;
			Debug.Log ("ACERTASTE");
			
		} 
		else 
		{
			miSolucion.Solucion = false;
			miHaContestado.HaContestado= true;
			Debug.Log("Fallaste");
		}

		
	}

	
}

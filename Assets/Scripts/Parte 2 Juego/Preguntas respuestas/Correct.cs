using UnityEngine;
using System.Collections;

public class Correct : MonoBehaviour {
	/*CON ESTA CLASE LO QUE HAGO ES COMPROBAR SI LA OPCION SELECCIONADA ES LA CORRECTA O NO*/
	

	
	//con esta variable marcare que ya ha contestado a la pregunta una vez se clicke un boton
	public GameObject haContestado;
	SolucionControlador miHaContestado;
	
	//con esta variable marcare que cual es la solucion a la pregunta, si verdadera o falsa
	public GameObject solucion;
	SolucionControlador miSolucion;
	
	
	
	
	
	/*******************************************************************************************************************************************/
	
	void Awake () {
		// inicializo las vaiables al comenzar la jugada

		miHaContestado = (SolucionControlador)haContestado.GetComponent (typeof(SolucionControlador));
		miSolucion = (SolucionControlador)solucion.GetComponent (typeof(SolucionControlador));
		
	}
	
	//funcion que uso cuadno se pulsa el boton para ver si es correcta o no la respuesta
	public void pressedButton()
	{

		miSolucion.Solucion = true;
		miHaContestado.HaContestado= true;

		
	}

}

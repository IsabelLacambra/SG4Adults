using UnityEngine;
using System.Collections;

public class ButtonA : MonoBehaviour {
	/*CON ESTA CLASE LO QUE HAGO ES COMPROBAR SI LA OPCION SELECCIONADA ES LA CORRECTA O NO*/

	//con esta variabe mirare si la respuest que he seleccionado es la correcta o no lo es
	public GameObject respA;
	ClsRespA miRespA;

	//con esta variable marcare que ya ha contestado a la pregunta una vez se clicke un boton
	public GameObject haContestado;
	SolucionControlador miHaContestado;

	//con esta variable marcare que cual es la solucion a la pregunta, si verdadera o falsa
	public GameObject solucion;
	SolucionControlador miSolucion;





/*******************************************************************************************************************************************/

	void Awake () {
		// inicializo las vaiables al comenzar la jugada
		miRespA = (ClsRespA)respA.GetComponent (typeof(ClsRespA));
		miHaContestado = (SolucionControlador)haContestado.GetComponent (typeof(SolucionControlador));
		miSolucion = (SolucionControlador)solucion.GetComponent (typeof(SolucionControlador));

	}

	//funcion que uso cuadno se pulsa el boton para ver si es correcta o no la respuesta
	public void pressedButton()
	{
		if (miRespA.EsCorrecta) 
		{

		
			miSolucion.Solucion = true;
			miHaContestado.HaContestado= true;
			Debug.Log ("ACERTASTE");
			Debug.Log(miHaContestado.HaContestado);
		} 
		else 
		{
			miSolucion.Solucion = false;
			miHaContestado.HaContestado= true;
			Debug.Log("Fallaste");
		}

	}

}






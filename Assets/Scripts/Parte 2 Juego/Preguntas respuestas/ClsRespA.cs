using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClsRespA : MonoBehaviour {

	//variable referida al texto de la respuesta 
	Text text;
	

	//variables a las que accederemos desde la clase Pregunta 
	string respuesta;
	bool esCorrecta;

//*******************************************************************************************************************************

	void Awake () {
		text = GetComponent<Text> ();
		
	} 

	
	// Use this for initialization
	void Update () {

		//en el caso de que no sea null, lo cual significara que hemos asigando un valor desde la clase Pregunta, lo imprimo por pantalla
		if (respuesta != null) {
			text.text = respuesta;

		}
	
	}



//***********************************************************************************************************************************

	//GETTERS Y SETTERS

	public string RespA{
		get{ return respuesta;}
		set { respuesta = value;}	
	}
	
	public bool EsCorrecta{
		get{ return esCorrecta;}
		set { esCorrecta = value;}	
	}

}

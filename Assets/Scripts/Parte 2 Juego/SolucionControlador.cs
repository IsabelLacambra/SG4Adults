using UnityEngine;
using System.Collections;

public class SolucionControlador : MonoBehaviour  {


	/*En esta clase una vez seleccionada una de las opciones lo que hacemos
	 * es desactivar todos los botones y el texto, y que desaparezcan, 
	 * y mostrar el resultado por pantalla Acierto/error, junto con un boton 
	 * que nos hace volver al tablero a seguir jugando*/


	public bool hacontestado = false; //booleano que uso para saber que han contestado a la pregunta

	public bool solucion = false; //booleano que uso para saber is ha contestado bien o ha contestado mal
	
	public bool bloquear = false; //dire que se bloquee una vez haya contestado a una pregunta

	public string textoSolucion = "";


	//para hacer desaparecer las preguntas una vez seleccionamos una
	public GameObject AButton;
	public GameObject BButton;
	public GameObject CButton;
	public GameObject DButton;

	public GameObject Correct;
	public GameObject Wrong;


	public GameObject Pregunta;
	public GameObject SolucionGO;
	public GameObject Siguiente;
	public GameObject Timer;
	TimerEditable mitimer;

	public GameObject MAS;
	public GameObject MENOS;

	public GameObject AText;
	public GameObject BText;
	public GameObject CText;
	public GameObject DText;

	
	public GameObject turnos;



	int puntuacion01;
	int puntuacion02;
	int puntuacion03;
	int puntuacion04;



	void Start () {
	
		mitimer = (TimerEditable)Timer.GetComponent (typeof(TimerEditable));
	}

	// Update is called once per frame
	void Update () {

		if(mitimer.timeRemaining<1){
			textoSolucion = "TIME OUT!";
			AText.SetActive(false);
			BText.SetActive(false);
			CText.SetActive(false);
			DText.SetActive(false);

			Correct.SetActive(false);
			Wrong.SetActive(false);

			AButton.SetActive(false);
			BButton.SetActive(false);
			CButton.SetActive(false);
			DButton.SetActive(false);
			
			Timer.SetActive(false);
			Pregunta.SetActive(false);
			MAS.SetActive(false);
			MENOS.SetActive(false);
			
			
			//activamos la solucion y el boton siguiente
			SolucionGO.SetActive(true);
			Siguiente.SetActive(true);

		}

		else if (hacontestado) {
			//desactivamos los botones y los textos
			AText.SetActive(false);
			BText.SetActive(false);
			CText.SetActive(false);
			DText.SetActive(false);
		
			Correct.SetActive(false);
			Wrong.SetActive(false);

			AButton.SetActive(false);
			BButton.SetActive(false);
			CButton.SetActive(false);
			DButton.SetActive(false);

			Timer.SetActive(false);
			Pregunta.SetActive(false);
			MAS.SetActive(false);
			MENOS.SetActive(false);


			//activamos la solucion y el boton siguiente
			SolucionGO.SetActive(true);
			Siguiente.SetActive(true);

			//asignamos el texto que aparecera en el cuadro de la solucion
			if(solucion && mitimer.timeRemaining!=0){
			
				textoSolucion = "CORRECT!";

			}
			else{

				textoSolucion = "WRONG ANSWER!";

			}
		}

	}

//*********************************************************************************************************************
//	GETTERS Y SETTERS

	public bool HaContestado{
		get{ return hacontestado;}
		set { hacontestado = value;}	
	}
	
	public bool Solucion{
		get{ return solucion;}
		set { solucion = value;}	
	}

	
	public bool Bloquear{
		get{ return bloquear;}
		set { bloquear = value;}	
	}

	public string TextoSolucion {
		get{ return textoSolucion;}
		set { textoSolucion = value;}
	}

}

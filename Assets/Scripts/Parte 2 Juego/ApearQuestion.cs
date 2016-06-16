using UnityEngine;
using System.Collections;

public class ApearQuestion : MonoBehaviour {
	/*Esta clase la uso para activar los botones y los textos dce las preguntas una vez
	 * acaba el timer del comienzo*/

	public GameObject AButton;
	public GameObject BButton;
	public GameObject CButton;
	public GameObject DButton;

	public GameObject AText;
	public GameObject BText;
	public GameObject CText;
	public GameObject DText;

	public GameObject MAS;
	public GameObject MENOS;

	public GameObject pregunta;

	public GameObject correct;
	public GameObject wrong;


	bool heActivado=false; //este booleano sirve para uqe una vez contesto y bloqueo las preguntas, no se vuelvan a mostrar por pantalla y desaparezcan

	
	public GameObject comenzarTimer;
	TimerEditable miTimer;

	public GameObject tipoDePregunta;
	Pregunta miTipoDePregunta;

	void Awake () {
		
		// inicializo las vaiables al comenzar la jugada
		miTimer = (TimerEditable)comenzarTimer.GetComponent (typeof(TimerEditable));
		miTipoDePregunta = (Pregunta)tipoDePregunta.GetComponent (typeof(Pregunta));

	}

//Update is called once per frame
	void Update () {


		//cuando acabe el timer entonces mostrare en pantalla la pregunta 
		if (CountDownTimer.timeisout && heActivado==false && miTipoDePregunta.Pregunta01) {
		
			if (miTipoDePregunta.TipoPregunta == false) {
				Debug.Log("He entrado en tipo 01");
				pregunta.SetActive(true);
				AText.SetActive(true);
				BText.SetActive(true);
				CText.SetActive(true);
				DText.SetActive(true);
				
				AButton.SetActive(true);
				BButton.SetActive(true);
				CButton.SetActive(true);
				DButton.SetActive(true);
				
				MAS.SetActive(true);
				MENOS.SetActive(true);
				comenzarTimer.SetActive(true);
				
				heActivado = true;
				miTimer.Comenzar = true;
			}


			else if (miTipoDePregunta.TipoPregunta) {
				Debug.Log("He entrado en tipo 02");
				pregunta.SetActive(true);

				correct.SetActive(true);
				wrong.SetActive(true);


				MAS.SetActive(true);
				MENOS.SetActive(true);
				comenzarTimer.SetActive(true);
				
				heActivado = true;
				miTimer.Comenzar = true;
			}

		}
	}

	//***********************************************************************************************************************************
	
	//GETTERS Y SETTERS
	
	public bool ApearQuestion01{
		get{ return heActivado;}
		set { heActivado = value;}	
	}

}

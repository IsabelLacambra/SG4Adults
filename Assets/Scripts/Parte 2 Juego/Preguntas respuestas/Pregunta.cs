using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pregunta : MonoBehaviour {

	/*Esta clase la uso para mostrar por pantalla la pregunta cuando se acaba el timer 
	 * usare la variable que hace referencia al numero de pregunta que toca y 
	 * el booleano en el que guardo si he asignado ya pregunta, 
	 * accedere a estas variables desde la clase Respuesta.cs para buscar e imprimir por pantalla la respuesta.*/



	//variable referida al texto de la pregunta 
	Text text;

	//con este booleano controlamos cuando hemos puesto una pregunta por pantalla
	public bool pregunta = false;

	//variable que guarde el "path" es constante porque no vamos a modificarla durante todo el juego
	public const string path = "items";

	//el numero de la pregunta para poder buscarlo en la base de datos que hemos creado
	int numeroPregunta;


	//utilizaremos este booleano para saber que es lo que debemos mostrar por pantalla, si las 4 opciones o un boton de el profe decide
	bool PreguntaTipo2;

	bool PreguntaTipo3 = false;

	//variables en las que gaurdaremos el texto referente a las preguntas y respuestas.
	string question;
	string correcta;
	string error1;
	string error2;
	string error3;


	//uso esta variable para coger informacion de la clase ClsRespA
	public GameObject respA;
	ClsRespA miRespA;

	public GameObject respB;
	ClsRespB miRespB;

	public GameObject respC;
	ClsRespC miRespC;

	public GameObject respD;
	ClsRespD miRespD;

	public GameObject CountDown;
	CountDownTimer miCountDown;

	public GameObject solucionador;
	SolucionControlador miSolucion;

//**********************************************************************************************************************

	void Awake () {
		text = GetComponent<Text> ();
	}


	// Use this for initialization
	void Start () {

		// inicializo las vaiables al comenzar la jugada
		miRespA = (ClsRespA)respA.GetComponent (typeof(ClsRespA));
		miRespB = (ClsRespB)respB.GetComponent (typeof(ClsRespB));
		miRespC = (ClsRespC)respC.GetComponent (typeof(ClsRespC));
		miRespD = (ClsRespD)respD.GetComponent (typeof(ClsRespD));

		miCountDown = (CountDownTimer)CountDown.GetComponent (typeof(CountDownTimer));
		miSolucion = (SolucionControlador)solucionador.GetComponent (typeof(SolucionControlador));
		//**********************************************************


	}



	// Update is called once per frame
	void Update () {
		if (miSolucion.HaContestado) {
			text.text = "";
		}
		//cuando acabe el timer entonces mostrare en pantalla la pregunta 
		if (miCountDown.CountDownTimeBool && pregunta == false) {
			ItemContainer ic = ItemContainer.Load(path);
			
			//rango entre todas las preguntas que hay para elegir una
			numeroPregunta = Random.Range (1, ic.items.Count);

			//buscamos la pregunta 
			foreach (Item item in ic.items) 
			{

				//si el numero de la pregunta es el que hemos obtenido con el random
				if( item.numero == numeroPregunta.ToString())
				{
					//comprobamos de que tipo es para imprimirlo por pantalla de una forma u otra
					if(item.tipo == "2"){
						question = item.pregunta;
						PreguntaTipo2 = true;
					}
				
					else if(item.tipo == "1"){
						//asignamos los datos a las variables
						question = item.pregunta;
						correcta = item.correcta;
						error1 = item.erronea1;
						error2 = item.erronea2; 
						error3 = item.erronea3;

						PreguntaTipo2 = false;

						AsignarRespuestas(correcta, error1,error2, error3);
					
					}

					
				}

			}
			//escribimos la pregunta por pantalla
			text.text =  question;

			//decimos que ya hemos escrito la pregunta para no volver a escribirla otra vez
			pregunta = true;



		}



	}



	/*esta funcion la usamos para asignar las respuestas de forma aleatoria, y que nunca salga la correcta en elmismo sitio 
	 * llamamos a la funcion desde start, una vez asignamos los datos de la base de datos a las variables*/

	void AsignarRespuestas(string correcta, string err1, string err2, string err3){

		//random de 1 a 4 en el que decidire cual de ellas va a ser la correcta
		int aux = Random.Range (1, 5);


		if (aux == 1) {
			miRespA.RespA = correcta;
			miRespA.EsCorrecta = true;

			//ahora las incorrectas
			miRespB.RespB = err1;
			miRespB.EsCorrecta = false;
			miRespC.RespC = err2;
			miRespC.EsCorrecta = false;
			miRespD.RespD = err3;
			miRespD.EsCorrecta = false;

		}
		if (aux == 2) {
			miRespB.RespB = correcta;
			miRespB.EsCorrecta = true;
			
			//ahora las incorrectas
			miRespA.RespA = err1;
			miRespA.EsCorrecta = false;
			miRespC.RespC = err2;
			miRespC.EsCorrecta = false;
			miRespD.RespD = err3;
			miRespD.EsCorrecta = false;
			
		}
		if (aux == 3) {
			miRespC.RespC = correcta;
			miRespC.EsCorrecta = true;
			
			//ahora las incorrectas
			miRespB.RespB = err1;
			miRespB.EsCorrecta = false;
			miRespA.RespA = err2;
			miRespA.EsCorrecta = false;
			miRespD.RespD = err3;
			miRespD.EsCorrecta = false;
			
		}
		if (aux == 4) {
			miRespD.RespD = correcta;
			miRespD.EsCorrecta = true;
			
			//ahora las incorrectas
			miRespB.RespB = err1;
			miRespB.EsCorrecta = false;
			miRespC.RespC = err2;
			miRespC.EsCorrecta = false;
			miRespA.RespA = err3;
			miRespA.EsCorrecta = false;
			
		}
		
	}



//**********************************************************************************************************************

	//GETTERS Y SETTERS
	
	public bool Pregunta01{
		get{ return pregunta;}
		set { pregunta = value;}	
	}
	

	public bool TipoPregunta{
		get{ return PreguntaTipo2;}
		set { PreguntaTipo2 = value;}	
	}

	
	public bool TipoPregunta3{
		get{ return PreguntaTipo3;}
		set { PreguntaTipo3 = value;}	
	}





}



























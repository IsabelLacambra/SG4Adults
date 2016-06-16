using UnityEngine;
using System.Collections;


public class ChangeScene : MonoBehaviour {

	//CLASE QUE UTILIZO PARA REINICIAR TODAS LAS VARIABLES ANTES DE PASAR A LA OTRA "ESCENA" PARA QUE CUANDO
	//VUELVA A JUGAR UNA PREGUNTA SE REINICIE TODO  

	public GameObject GO2;
	public GameObject GO1;



//********************************************************************************************************************************
	public GameObject count;
	CountDownTimer miCount;


	public GameObject clase;
	ClsRespA miClase;
	public GameObject claseb;
	ClsRespB miClaseb;
	public GameObject clasec;
	ClsRespC miClasec;
	public GameObject clased;
	ClsRespD miClased;


	public GameObject pregunta;
	Pregunta miPregunta;


	public GameObject timer;
	TimerEditable miTimer;


	public GameObject apquestion;
	ApearQuestion miapear;


	public GameObject control;
	SolucionControlador miControl;


	//********

	public GameObject infoEquipo01;
	equipo01 miEquipo01;
	public GameObject infoEquipo02;
	equipo02 miEquipo02;
	public GameObject infoEquipo03;
	equipo03 miEquipo03;
	public GameObject infoEquipo04;
	equipo04 miEquipo04;
	public GameObject infoCelda;
	ListaCeldas miCelda;


	//*********
	public GameObject turnos;
	OrganizadorEquipos miTurno;
	
	public GameObject solucion;
	SolucionControlador miSolucion;
	
	//*****************************

	public GameObject puntEq01;
	Puntos01 miPuntEq1;
	
	public GameObject puntEq02;
	Puntos02 miPuntEq2;
	
	public GameObject puntEq03;
	Puntos03 miPuntEq3;
	
	public GameObject puntEq04;
	Puntos04 miPuntEq4;


	//*************************************


	public GameObject Siguiente;

	void Start () {

		miEquipo01 = (equipo01)infoEquipo01.GetComponent (typeof(equipo01));
		miEquipo02 = (equipo02)infoEquipo02.GetComponent (typeof(equipo02));
		miEquipo03 = (equipo03)infoEquipo03.GetComponent (typeof(equipo03));
		miEquipo04 = (equipo04)infoEquipo04.GetComponent (typeof(equipo04));
		miCelda = (ListaCeldas)infoCelda.GetComponent (typeof(ListaCeldas));


		miPuntEq1 = (Puntos01)puntEq01.GetComponent (typeof(Puntos01));
		miPuntEq2 = (Puntos02)puntEq02.GetComponent (typeof(Puntos02));
		miPuntEq3 = (Puntos03)puntEq03.GetComponent (typeof(Puntos03));
		miPuntEq4 = (Puntos04)puntEq04.GetComponent (typeof(Puntos04));


		miCount = (CountDownTimer)count.GetComponent (typeof(CountDownTimer));
		miClase = (ClsRespA)clase.GetComponent (typeof(ClsRespA));
		miClaseb = (ClsRespB)claseb.GetComponent (typeof(ClsRespB));
		miClasec = (ClsRespC)clasec.GetComponent (typeof(ClsRespC));
		miClased = (ClsRespD)clased.GetComponent (typeof(ClsRespD));
		miPregunta = (Pregunta)pregunta.GetComponent (typeof(Pregunta));
		miTimer = (TimerEditable)timer.GetComponent (typeof(TimerEditable));
		miapear = (ApearQuestion)apquestion.GetComponent (typeof(ApearQuestion));
		miControl = (SolucionControlador)control.GetComponent (typeof(SolucionControlador));

		miTurno = (OrganizadorEquipos)turnos.GetComponent (typeof(OrganizadorEquipos));
		miSolucion = (SolucionControlador)solucion.GetComponent (typeof(SolucionControlador));
	}
//********************************************************************************************************************************





	// Use this for initialization
	public void LoadLevel () {

		//actualizo las puntuaciones de los equipos
		//compruebo de quien era el turno y si ha acertado le sumo 10 puntos
	
		if (miSolucion.Solucion) {
			if (miTurno.eq1) {
				miPuntEq1.PuntosEq01 += 1;
				miCelda.Bloqueado [System.Int32.Parse (miEquipo01.Posicion01)] = true;
				Debug.Log ("ACABO DE BLOQUEAR UNA CELDA");

			} else if (miTurno.eq2) {
				miPuntEq2.PuntosEq02 += 1;
				miCelda.Bloqueado [System.Int32.Parse (miEquipo02.Posicion02)] = true;
				Debug.Log ("ACABO DE BLOQUEAR UNA CELDA");

			} else if (miTurno.eq3) {
				
				miPuntEq3.PuntosEq03 += 1;
				miCelda.Bloqueado [System.Int32.Parse (miEquipo03.Posicion03)] = true;
				Debug.Log ("ACABO DE BLOQUEAR UNA CELDA");

			} else if (miTurno.eq4) {
				miPuntEq4.PuntosEq04 += 1;
				miCelda.Bloqueado [System.Int32.Parse (miEquipo04.Posicion04)] = true;
				Debug.Log ("ACABO DE BLOQUEAR UNA CELDA");

			}
		
		} 



	    //********************************************************************************************************************************


		//AQUI DEBO PINTAR LA CELDA DE OTRO COLOR mas clarito para dar a entender que esa es la pos poer que no esta bloqueada
		//he de mirar luego en la calse fichas colores que si hay alguna celda que no esta bloqueada y que no tiene el color azul, que le ponga el color azul



		//********************************************************************************************************************************


		//reinicio todas las variables del GameObject2 que necesitan ser reseteadas para cuando se vuelva a jugar
		miCount.CountDownTime = 5;
		miCount.CountDownTimeBool = false;

		miClase.RespA = null;
		miClaseb.RespB = null;
		miClasec.RespC = null;
		miClased.RespD = null;


		miPregunta.Pregunta01 = false;
		miPregunta.TipoPregunta = false;

		miTimer.Comenzar = false;
		miTimer.TimeRemaining = 30;

		miapear.ApearQuestion01 = false;

		miControl.HaContestado = false;
		miControl.Solucion=false;
		miControl.Bloquear = false;
		miControl.TextoSolucion = "";


		Siguiente.SetActive(false);
		//********************************************************************************************************************************


		//activo el tablero y desactivo las preguntas
		GO2.SetActive(false);
		GO1.SetActive(true);





	}





}

	
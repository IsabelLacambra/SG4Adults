using UnityEngine;
using System.Collections;

public class equipo02 : MonoBehaviour {
	

	
	// Uso esta variable para coger informacion de la clase OrganizadorEquipos, para saber cuando es mi turno y poder mover ficha
	public GameObject orgEquipos;
	OrganizadorEquipos miEquipo;
	
	//uso esta variable para coger informacion de la clase Dado
	public GameObject goDado;
	Dado miDado;
	
	//uso esta variable para coger informacion de la clase Dado
	public GameObject goDado2;
	Dado2 miDado2;

	//uso esta variable para saber cual fue la ultima celda clickada
	public GameObject infoClicked;
	UltimaVezClickado miClick;
	
	//uso esta variable para ver cuales son los vecinos de cada celda
	public GameObject infoCelda;
	ListaCeldas miCelda;
	
	
	//uso esta variable para comprobar los puntos que tengo si cuando clico en una de las casillas de salida
	public GameObject puntosEq2;
	Puntos02 miPuntuacion2; 

	//movimientos restantes que le quedan al jugador, lo inicializamos con el numero que ha salido en el dado
	int movDado;
	int movHechos=0;
	
	//celdas clickadas, la 01 es mi posicion actual, y la 02 es la que acabo de clickar y que compruebo si esta en los vecinos de mi posicion
	string posicion = "1";
	string ultimaClickada;
	
	//variable que uso para guardar los vecinos de las celdas a las que consulto los datos
	int[] vecinosMyPos;
	
	//variable que pongo a true cuando he acabado de mover la ficha, para asi poder desbloquear el Dado2 y poder hacer la pregunta
	bool heAcabado = false;
	
	
	//uso esta variable para colorearla una vez haya acabado de mover ficha
	string posicionFinal;
	//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	
	
	// Use this for initialization
	void Start () {
		miPuntuacion2 = (Puntos02)puntosEq2.GetComponent (typeof(Puntos02));
		// inicializo las vaiables al comenzar la jugada
		miEquipo = (OrganizadorEquipos)orgEquipos.GetComponent (typeof(OrganizadorEquipos));
		miDado = (Dado)goDado.GetComponent (typeof(Dado));
		miDado2 = (Dado2)goDado2.GetComponent (typeof(Dado2));
		miClick = (UltimaVezClickado)infoClicked.GetComponent (typeof(UltimaVezClickado));
		miCelda = (ListaCeldas)infoCelda.GetComponent (typeof(ListaCeldas));
		
		
	}
	
	
	//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	
	
	// Update is called once per frame
	void Update () {
		
		
		//en el caso de que haya tirado el dado
		movDado = miDado.ResultadoDado;
		
		
		ultimaClickada = miClick.LastClicked;
		//Debug.Log (ultimaClickada);
		
		//si es el turno de mi equipo
		if (miEquipo.Eq2) {
		
			//si he tirado el dado
			if (miDado.ResultadoDado != null && miDado.DadoTirado==true) {

				//si me quedan movimientos
				if (movDado > movHechos) {
					funcionlarga();
				}else{
					posicionFinal = posicion;
					heAcabado = true;
				
				}
			}
		}
		
		if (miDado2.TocaPregunta && heAcabado) {
			miEquipo.Eq2 = false;
			miEquipo.Eq3 = true;
			//actualizao las variables para que vuelvan a estar false cuando comience el turno del otro equipo
			miDado.DadoTirado = false;
			miDado2.TocaPregunta = false;
			movHechos=0;
		}
		
		
		
	}
	
	
	//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	
	//funcion que uso para comprobar que la celda que he clicado por ultima vez tiene como vecina a mi posicion 
	bool celdaInVecinos(int[] vecinosMyPos, string posActual){
		
		int tamaño = vecinosMyPos.Length;
		
		for (int i = 0; i< tamaño; i++) {
			
			string aux1 = vecinosMyPos[i].ToString();
			
			if(string.Equals (aux1,posActual))
				return true;	
		}
		
		return false;
		
	}
	
	
	
	
	//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	
	public bool HeAcabado{
		get{ return heAcabado;}
		set { heAcabado = value;}	
	}
	public string Posicion02{
		get{ return posicionFinal;}
		set { posicionFinal = value;}	
	}

	
	//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	
	
	
	//*********************************************************************************************************
	//Si la ultima celda es x 
	//guardo en la variable vecinosMyPos los vecinos de la celda x
	//llamo a la funcion celdaInVecinos para saber si la celda x es vecina de mi posicion actual
	//en el caso de que si
	//actualizo la posicion --> mi posicion es = x
	//sumo 1 a la variable de movHechos, para controlar cuantos mov me quedan por hacer
	//*********************************************************************************************************



	void funcionlarga(){
		
		if(string.Equals(ultimaClickada, "2")){
			vecinosMyPos =miCelda.C2 ;
			if(!miCelda.Bloqueado[2]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "2";
					movHechos = movHechos +1;}
			}
			else{
				Debug.Log("ESTA BLOQUEADA");
			}
		}else if(string.Equals(ultimaClickada, "3")){
			vecinosMyPos =miCelda.C3 ;
			if(!miCelda.Bloqueado[3]){
				if(celdaInVecinos(vecinosMyPos,posicion) ){
					Debug.Log("HA ENTRADO");
					posicion = "3";
					movHechos = movHechos +1;}
			}	
		}else if(string.Equals(ultimaClickada, "4")){
			vecinosMyPos =miCelda.C4 ;
			if(!miCelda.Bloqueado[4]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "4";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "5")){
			vecinosMyPos =miCelda.C5 ;
			if(!miCelda.Bloqueado[5]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "5";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "6")){
			vecinosMyPos =miCelda.C6 ;
			if(!miCelda.Bloqueado[6]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "6";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "7")){
			vecinosMyPos =miCelda.C7 ;
			if(!miCelda.Bloqueado[7]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "7";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "8")){
			vecinosMyPos =miCelda.C8 ;
			if(!miCelda.Bloqueado[8]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "8";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "9")){
			vecinosMyPos =miCelda.C9 ;
			if(!miCelda.Bloqueado[9]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "9";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "10")){
			vecinosMyPos =miCelda.C10 ;
			if(!miCelda.Bloqueado[10]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "10";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "11")){
			vecinosMyPos =miCelda.C11 ;
			if(!miCelda.Bloqueado[11]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "11";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "12")){
			vecinosMyPos =miCelda.C12 ;
			if(!miCelda.Bloqueado[12]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "12";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "13")){
			vecinosMyPos =miCelda.C13 ;
			if(!miCelda.Bloqueado[13]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "13";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "14")){
			vecinosMyPos =miCelda.C14 ;
			if(!miCelda.Bloqueado[14]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "14";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "15")){
			vecinosMyPos =miCelda.C15 ;
			if(!miCelda.Bloqueado[15]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "15";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "16")){
			vecinosMyPos =miCelda.C16 ;
			if(!miCelda.Bloqueado[16]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "16";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "17")){
			vecinosMyPos =miCelda.C17 ;
			if(!miCelda.Bloqueado[17]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "17";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "18")){
			vecinosMyPos =miCelda.C18 ;
			if(!miCelda.Bloqueado[18]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "18";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "19")){
			vecinosMyPos =miCelda.C19 ;
			if(!miCelda.Bloqueado[19]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "19";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "20")){
			vecinosMyPos =miCelda.C20 ;
			if(!miCelda.Bloqueado[20]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "20";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "21")){
			vecinosMyPos =miCelda.C21 ;
			if(!miCelda.Bloqueado[21]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "21";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "22")){
			vecinosMyPos =miCelda.C22 ;
			if(!miCelda.Bloqueado[22]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "22";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "23")){
			vecinosMyPos =miCelda.C23 ;
			if(!miCelda.Bloqueado[23]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "23";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "24")){
			vecinosMyPos =miCelda.C24 ;
			if(!miCelda.Bloqueado[24]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "24";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "25")){
			vecinosMyPos =miCelda.C25 ;
			if(!miCelda.Bloqueado[25]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "25";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "26")){
			vecinosMyPos =miCelda.C26 ;
			if(!miCelda.Bloqueado[26]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "26";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "27")){
			vecinosMyPos =miCelda.C27 ;
			if(!miCelda.Bloqueado[27]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "27";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "28")){
			vecinosMyPos =miCelda.C28 ;
			if(!miCelda.Bloqueado[28]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "28";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "29")){
			vecinosMyPos =miCelda.C29 ;
			if(!miCelda.Bloqueado[29]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "29";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "30")){
			vecinosMyPos =miCelda.C30 ;
			if(!miCelda.Bloqueado[30]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "30";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "31")){
			vecinosMyPos =miCelda.C31 ;
			if(!miCelda.Bloqueado[31]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "31";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "32")){
			vecinosMyPos =miCelda.C32 ;
			if(!miCelda.Bloqueado[32]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "32";
					movHechos = movHechos +1;}
			}
			
			
			
			
			
			
			
			
		}else if(string.Equals(ultimaClickada, "33")){
			vecinosMyPos =miCelda.C33 ;
			if(!miCelda.Bloqueado[33]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "33";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "34")){
			vecinosMyPos =miCelda.C34 ;
			if(!miCelda.Bloqueado[34]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "34";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "35")){
			vecinosMyPos =miCelda.C35 ;
			if(celdaInVecinos(vecinosMyPos,posicion)){
				if(miPuntuacion2.PuntosEq02 >= 10) {
					Debug.Log("Fin");
					Application.LoadLevel ("Scene05");
				}
			}

		}else if(string.Equals(ultimaClickada, "36")){
			vecinosMyPos =miCelda.C36 ;
			if(!miCelda.Bloqueado[36]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "36";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "37")){
			vecinosMyPos =miCelda.C37 ;
			if(!miCelda.Bloqueado[37]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "37";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "38")){
			vecinosMyPos =miCelda.C38 ;
			if(!miCelda.Bloqueado[38]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "38";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "39")){
			vecinosMyPos =miCelda.C39 ;
			if(!miCelda.Bloqueado[39]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "39";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "40")){
			vecinosMyPos =miCelda.C40 ;
			if(!miCelda.Bloqueado[40]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "40";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "41")){
			vecinosMyPos =miCelda.C41 ;
			if(!miCelda.Bloqueado[41]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "41";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "42")){
			vecinosMyPos =miCelda.C42 ;
			if(!miCelda.Bloqueado[42]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "42";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "43")){
			vecinosMyPos =miCelda.C43 ;
			if(!miCelda.Bloqueado[43]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "43";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "44")){
			vecinosMyPos =miCelda.C44 ;
			if(!miCelda.Bloqueado[44]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "44";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "45")){
			vecinosMyPos =miCelda.C45 ;
			if(!miCelda.Bloqueado[45]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "45";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "46")){
			vecinosMyPos =miCelda.C46 ;
			if(!miCelda.Bloqueado[46]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "46";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "47")){
			vecinosMyPos =miCelda.C47 ;
			if(!miCelda.Bloqueado[47]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "47";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "48")){
			vecinosMyPos =miCelda.C48 ;
			if(!miCelda.Bloqueado[48]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "48";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "49")){
			vecinosMyPos =miCelda.C49 ;
			if(!miCelda.Bloqueado[49]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "49";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "50")){
			vecinosMyPos =miCelda.C50 ;
			if(!miCelda.Bloqueado[50]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "50";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "51")){
			vecinosMyPos =miCelda.C51 ;
			if(!miCelda.Bloqueado[51]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "51";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "52")){
			vecinosMyPos =miCelda.C52 ;
			if(!miCelda.Bloqueado[52]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "52";
					movHechos = movHechos +1;}
			}
			
			
			
			
		}else if(string.Equals(ultimaClickada, "53")){
			vecinosMyPos =miCelda.C53 ;
			if(!miCelda.Bloqueado[53]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "53";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "54")){
			vecinosMyPos =miCelda.C54 ;
			if(!miCelda.Bloqueado[54]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "54";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "55")){
			vecinosMyPos =miCelda.C55 ;
			if(!miCelda.Bloqueado[55]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "55";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "56")){
			vecinosMyPos =miCelda.C56 ;
			if(!miCelda.Bloqueado[56]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "56";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "57")){
			vecinosMyPos =miCelda.C57 ;
			if(celdaInVecinos(vecinosMyPos,posicion)){
				if(miPuntuacion2.PuntosEq02 >= 10) {
					Debug.Log("Fin");
					Application.LoadLevel ("Scene05");
				}
			}

		}else if(string.Equals(ultimaClickada, "58")){
			vecinosMyPos =miCelda.C58 ;
			if(!miCelda.Bloqueado[58]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "58";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "59")){
			vecinosMyPos =miCelda.C59 ;
			if(!miCelda.Bloqueado[59]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "59";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "60")){
			vecinosMyPos =miCelda.C60 ;
			if(!miCelda.Bloqueado[60]){
				if(celdaInVecinos(vecinosMyPos,posicion)){
					Debug.Log("HA ENTRADO");
					posicion = "60";
					movHechos = movHechos +1;}
			}
		}else if(string.Equals(ultimaClickada, "61")){
			vecinosMyPos =miCelda.C61 ;
			if(celdaInVecinos(vecinosMyPos,posicion)){
				if(miPuntuacion2.PuntosEq02 >= 10) {
					Debug.Log("Fin");
					Application.LoadLevel ("Scene05");
				}
			}

		}
		
	}











}

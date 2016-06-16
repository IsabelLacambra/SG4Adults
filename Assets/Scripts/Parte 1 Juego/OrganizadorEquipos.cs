using UnityEngine;
using System.Collections;

public class OrganizadorEquipos : MonoBehaviour {

	//variable que indica si es mi turno o no
	public bool eq1 = true;
	public bool eq2 = false;
	public bool eq3 = false;
	public bool eq4 = false;

	//variable con la que asocio cada uno de los game objects asociados a cada uno de los equipos para asi poder bloquerarlos cuando no les toque jugar
	public GameObject equipo1;
	public GameObject equipo2;
	public GameObject equipo3;
	public GameObject equipo4;

	
	public GameObject puntuaciones;



	void Update () {
		if (eq1) {//bloqueo aquellos equipos a los que no les toque jugar
			equipo2.SetActive(false);
			equipo3.SetActive(false);
			equipo4.SetActive(false);
			equipo1.SetActive(true);


		}
		else if (eq2) {
			equipo1.SetActive(false);
			equipo3.SetActive(false);
			equipo4.SetActive(false);
			equipo2.SetActive(true);
		}
		else if (eq3) {
			equipo2.SetActive(false);
			equipo1.SetActive(false);
			equipo4.SetActive(false);
			equipo3.SetActive(true);
		}
		else if (eq4) {
			equipo2.SetActive(false);
			equipo3.SetActive(false);
			equipo1.SetActive(false);
			equipo4.SetActive(true);
		}

	}	

	public bool Eq1{
		get{return eq1;}
		set{eq1=value;}
	}

	public bool Eq2{
		get{return eq2;}
		set{eq2=value;}
	}
	public bool Eq3{
		get{return eq3;}
		set{eq3=value;}
	}
	public bool Eq4{
		get{return eq4;}
		set{eq4=value;}
	}




}

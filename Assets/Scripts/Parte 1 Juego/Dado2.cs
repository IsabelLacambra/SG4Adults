using UnityEngine;
using System.Collections;

public class Dado2 : MonoBehaviour {


	/*En esta clase compruebo si el equipo ya ha movido ficha y puede pasar a contestar la pregunta*/

	bool tocaPregunta = false;

	public Texture txtblanco;

	public GameObject e01;
	equipo01 miEq01;

	public GameObject e02;
	equipo02 miEq02;

	public GameObject e03;
	equipo03 miEq03;

	public GameObject e04;
	equipo04 miEq04;


	public GameObject GO2;
	public GameObject GO1;

	public GameObject DadoUno;

	void Start(){
		miEq01 = (equipo01)e01.GetComponent (typeof(equipo01));
		miEq02 = (equipo02)e02.GetComponent (typeof(equipo02));
		miEq03 = (equipo03)e03.GetComponent (typeof(equipo03));
		miEq04 = (equipo04)e04.GetComponent (typeof(equipo04));
	}



	void OnMouseDown(){
		if (miEq01.HeAcabado) {
			tocaPregunta = true;
			miEq01.HeAcabado = false;
		}
		else if (miEq02.HeAcabado) {
			tocaPregunta = true;
			miEq01.HeAcabado = false;
		}
		else if (miEq03.HeAcabado) {
			tocaPregunta = true;
			miEq01.HeAcabado = false;
		}
		else if (miEq04.HeAcabado) {
			tocaPregunta = true;
			miEq01.HeAcabado = false;
		}
	

		DadoUno.renderer.material.mainTexture = txtblanco;



		GO2.SetActive(true);
		GO1.SetActive(false);
	

	}



	public bool TocaPregunta{
		get{ return tocaPregunta;}
		set { tocaPregunta = value;}
		
	}


}

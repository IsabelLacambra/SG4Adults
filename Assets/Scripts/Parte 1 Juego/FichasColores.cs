using UnityEngine;
using System.Collections;

public class FichasColores : MonoBehaviour {

	
	public GameObject posEq01;
	equipo01 miPosEq01;

	public GameObject posEq02;
	equipo02 miPosEq02;

	public GameObject posEq03;
	equipo03 miPosEq03;
	
	public GameObject posEq04;
	equipo04 miPosEq04;


	public Color startBLUE;

	public GameObject infoCelda;
	ListaCeldas miCelda;



	SpriteRenderer sr;

	public Sprite hex1;
	public Sprite hex2;
	public Sprite hex3;
	public Sprite hex4;


	void Start () {
		
		// variable que uso para coger de la calse equipo1 la posicion final tras mover la ficha
		miPosEq01 = (equipo01)posEq01.GetComponent (typeof(equipo01));


		// variable que uso para coger de la calse equipo2 la posicion final tras mover la ficha
		miPosEq02 = (equipo02)posEq02.GetComponent (typeof(equipo02));


		// variable que uso para coger de la calse equipo1 la posicion final tras mover la ficha
		miPosEq03 = (equipo03)posEq03.GetComponent (typeof(equipo03));
		
		
		// variable que uso para coger de la calse equipo2 la posicion final tras mover la ficha
		miPosEq04 = (equipo04)posEq04.GetComponent (typeof(equipo04));

	
		miCelda = (ListaCeldas)infoCelda.GetComponent (typeof(ListaCeldas));


		sr = GetComponent<SpriteRenderer>();

	}




	void Update(){


		//guardo el nombre de la ficha
		string aux = gameObject.name;


		//guardo el nombre de la ficha en la que esta mi equipo
		string aux2_1 = miPosEq01.Posicion01;
		//guardo el nombre de la ficha en la que esta mi equipo
		string aux2_2 = miPosEq02.Posicion02;
		//guardo el nombre de la ficha en la que esta mi equipo
		string aux2_3 = miPosEq03.Posicion03;
		//guardo el nombre de la ficha en la que esta mi equipo
		string aux2_4 = miPosEq04.Posicion04;

		
		//*******************************************************************************************************************************************************************************************************
	
		//*******************************************************************************************************************************************************************************************************
		//funciones que uso para poner a rojo las casillas


		//si he acabado de hacer los movimientos 
		if (miPosEq01.HeAcabado) {
			 aux2_1 = miPosEq01.Posicion01;

			//y la variable aux es dif de null por lo tanto hay una posicion final en la uqe esta la ficha de mi equipo
			if (aux2_1 != null) {

				//y esta posicion coincide con la de la ficha a la que pertenece el script
				if (string.Equals (aux, aux2_1)) {


					sr.sprite = hex1;
				}
			}
		}

		//si he acabado de hacer los movimientos 
		if (miPosEq02.HeAcabado) {
			aux2_2 = miPosEq02.Posicion02;
			
			//y la variable aux es dif de null por lo tanto hay una posicion final en la uqe esta la ficha de mi equipo
			if (aux2_2 != null) {
				
				//y esta posicion coincide con la de la ficha a la que pertenece el script
				if (string.Equals (aux, aux2_2)) {

					//entonces pinto la celda de rojo
					sr.sprite = hex2;
				}
			}
		}

		//si he acabado de hacer los movimientos 
		if (miPosEq03.HeAcabado) {
			aux2_3 = miPosEq03.Posicion03;
			
			//y la variable aux es dif de null por lo tanto hay una posicion final en la uqe esta la ficha de mi equipo
			if (aux2_3 != null) {
				
				//y esta posicion coincide con la de la ficha a la que pertenece el script
				if (string.Equals (aux, aux2_3)) {
				
					//entonces pinto la celda de rojo
					sr.sprite = hex3;

				}
			}
		}

		//si he acabado de hacer los movimientos 
		if (miPosEq04.HeAcabado) {
			aux2_4 = miPosEq04.Posicion04;
			
			//y la variable aux es dif de null por lo tanto hay una posicion final en la uqe esta la ficha de mi equipo
			if (aux2_4 != null) {
				
				//y esta posicion coincide con la de la ficha a la que pertenece el script
				if (string.Equals (aux, aux2_4)) {
		
					//entonces pinto la celda de rojo
					sr.sprite = hex4;
				}
			}
		}

		//*******************************************************************************************************************************************************************************************************
		//*******************************************************************************************************************************************************************************************************



	
	
	
	
	
	
	
	
	
	
	}


}

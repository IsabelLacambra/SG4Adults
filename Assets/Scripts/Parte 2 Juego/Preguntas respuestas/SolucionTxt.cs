using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SolucionTxt : MonoBehaviour {


	//variable referida al texto de la solucion 
	Text text;


	public GameObject sol;
	SolucionControlador misol;



	void Awake () {
		text = GetComponent<Text> ();
		misol = (SolucionControlador)sol.GetComponent (typeof(SolucionControlador));
	}


	// Update is called once per frame
	void Update () {
		text.text = misol.TextoSolucion;
	}
}

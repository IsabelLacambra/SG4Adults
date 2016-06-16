using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClsRespC : MonoBehaviour {
	
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

		/*public class ExampleClass : MonoBehaviour {
    public GameObject prefab;
    
    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
    void Start() {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 0, Random.Range(-10.0F, 10.0F));
        Instantiate(prefab, position, Quaternion.identity);
    }
}*/
	}


	//***********************************************************************************************************************************
	

	//GETTERS Y SETTERS

	public string RespC{
		get{ return respuesta;}
		set { respuesta = value;}	
	}
	
	public bool EsCorrecta{
		get{ return esCorrecta;}
		set { esCorrecta = value;}	
	}
}

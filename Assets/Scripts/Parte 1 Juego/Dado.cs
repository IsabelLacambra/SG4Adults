using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dado : MonoBehaviour {
	
	public Texture uno;
	public Texture dos;
	public Texture tres;
	public Texture cuatro;
	public Texture cinco;
	public Texture seis;

	int resultadoDado = 0;

	//variable que uso para controlar el dado, una vez lo "tiro" lo que hare sera bloquerarlo para que no se pueda volver a "tirar"
	bool dadoTirado = false;


	void OnMouseDown(){
		//calculo el resultado con un random
		resultadoDado = UnityEngine.Random.Range (1, 7);

		//si era la primera vez que tiraba el dado
		if (dadoTirado == false) {

			//asigno las texturas al dado
			if (resultadoDado == 1) 
				renderer.material.mainTexture = uno;
			 else if (resultadoDado == 2) 
				renderer.material.mainTexture = dos;
			 else if (resultadoDado == 3) 
				renderer.material.mainTexture = tres;
			 else if (resultadoDado == 4) 
				renderer.material.mainTexture = cuatro;
			 else if (resultadoDado == 5) 
				renderer.material.mainTexture = cinco;
			 else if (resultadoDado == 6) 
				renderer.material.mainTexture = seis;

			//he tirado el dado, por lo que ya no lo puedo volver a tirar
			dadoTirado = true;
		}
		
	}


	public int ResultadoDado{
		get{return resultadoDado;}
		set{resultadoDado=value;}
	}


	public bool DadoTirado{
		get{ return dadoTirado;}
		set { dadoTirado = value;}
	
	}
}

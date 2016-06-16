using UnityEngine;
using System.Collections;

public class ImagenControlador : MonoBehaviour {


	public GameObject imagenFondo;
	Pregunta miImagen;

	/*public string url;


	IEnumerator Start() {
		url = miImagen.imagen;
		if (miImagen.TipoPregunta3) {
			while (true) {
				WWW www = new WWW(url);
				
				yield return www;
				
				Renderer renderer = GetComponent<Renderer>();
				renderer.material.mainTexture = www.texture;
				
			}
		}

	}
*/
	void Awake () {
		
		// inicializo las vaiables al comenzar la jugada
		miImagen = (Pregunta)imagenFondo.GetComponent (typeof(Pregunta));
	}

	public string url = "hola";
	
	IEnumerator Start() {
		// Start a download of the given URL
		WWW www = new WWW(url);
		
		// Wait for download to complete
		yield return www;
		
		// assign texture
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = www.texture;
	}

}

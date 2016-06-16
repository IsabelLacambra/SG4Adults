using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotonPlay : MonoBehaviour {

	public Sprite pulsado;

	SpriteRenderer boton;

	void Start(){
	
		boton = GetComponent<SpriteRenderer> ();
	}

	void OnMouseDown() {
		boton.sprite = pulsado;
		Application.LoadLevel ("Scene02");
	}
}

using UnityEngine;
using System.Collections;

public class BotonCredits : MonoBehaviour {
	public Sprite pulsado;
	
	SpriteRenderer boton;
	
	void Start(){
		
		boton = GetComponent<SpriteRenderer> ();
	}
	
	void OnMouseDown() {
		boton.sprite = pulsado;
		Application.LoadLevel ("Scene09");
	}
}

using UnityEngine;
using System.Collections;

public class ChangeColorOnMouseOver : MonoBehaviour {

	SpriteRenderer sr;

	public GameObject infoCelda;
	ListaCeldas miCelda;

	public Sprite startHex;

	public Sprite hex;

	void Start ()
	{
		sr = GetComponent<SpriteRenderer>();
		miCelda = (ListaCeldas)infoCelda.GetComponent (typeof(ListaCeldas));

	}


	void OnMouseEnter()
	{
		if (miCelda.Bloqueado [System.Int32.Parse (gameObject.name)] == false) {
			sr.sprite = hex;
		}

	}


	void OnMouseExit()
	{
		if (miCelda.Bloqueado [System.Int32.Parse (gameObject.name)] == false) {
			sr.sprite = startHex;
		}
	
	
	}



}


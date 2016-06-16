using UnityEngine;
using System.Collections;

public class Numeros2 : MonoBehaviour {
	public GameObject puntosEq1;
	Puntos02 miPuntuacion1; 
	
	
	SpriteRenderer sr;
	
	
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	public Sprite s6;
	public Sprite s7;
	public Sprite s8;
	public Sprite s9;
	public Sprite s10;
	
	
	int puntos =0;
	
	void Start () {
		miPuntuacion1 = (Puntos02)puntosEq1.GetComponent (typeof(Puntos02));
		
		sr = GetComponent<SpriteRenderer>();
		
	}
	
	void Update(){
		
		if (miPuntuacion1.PuntosEq02 == 1) {
			sr.sprite = s1;
		}
		
		else if (miPuntuacion1.PuntosEq02  == 2) {
			sr.sprite = s2;
		}
		else if (miPuntuacion1.PuntosEq02  == 3) {
			sr.sprite = s3;
		}
		else if (miPuntuacion1.PuntosEq02  == 4) {
			sr.sprite = s4;
		}
		else if (miPuntuacion1.PuntosEq02  == 5) {
			sr.sprite = s5;
		}
		else if (miPuntuacion1.PuntosEq02  == 6) {
			sr.sprite = s6;
		}
		else if (miPuntuacion1.PuntosEq02  == 7) {
			sr.sprite = s7;
		}
		else if (miPuntuacion1.PuntosEq02  == 8) {
			sr.sprite = s8;
		}
		else if (miPuntuacion1.PuntosEq02  == 9) {
			sr.sprite = s9;
		}
		else if (miPuntuacion1.PuntosEq02  == 10) {
			sr.sprite = s10;
		}
	}

}

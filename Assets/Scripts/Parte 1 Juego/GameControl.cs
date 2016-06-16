﻿using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	//variables que quiero guardar




	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if(control!=this){
			Destroy(gameObject);
		}

	}

}

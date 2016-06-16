using UnityEngine;
using System.Collections;

public class UltimaVezClickado : MonoBehaviour {


	GameObject lastClicked;
	Ray ray;
	RaycastHit rayHit;
	string _lastClicked;

	void Update()
	{
		if(Input.GetMouseButtonDown (0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out rayHit))
			{
				lastClicked = rayHit.collider.gameObject;
				if(lastClicked != null){
					print(lastClicked.name);
					_lastClicked = lastClicked.name;
				
				}
			}
		}
	}


	public string LastClicked{
		get{return _lastClicked;}
		set{_lastClicked=value;}
	}



}

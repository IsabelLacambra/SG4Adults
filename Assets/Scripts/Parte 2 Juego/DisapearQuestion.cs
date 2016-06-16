using UnityEngine;
using System.Collections;

public class DisapearQuestion : MonoBehaviour {

	/*Esta clase la uso para desactivar los botones y los textos dce las preguntas una vez
	 * he contestado a la pregunta, de esta manera pondre la solucion por pantalla
	 */
	
	public GameObject AButton;
	public GameObject BButton;
	public GameObject CButton;
	public GameObject DButton;
	
	public GameObject AText;
	public GameObject BText;
	public GameObject CText;
	public GameObject DText;
	

	
	// Update is called once per frame
	public void DesactivarBotones () {
			AText.SetActive(false);
			BText.SetActive(false);
			CText.SetActive(false);
			DText.SetActive(false);
			
			AButton.SetActive(false);
			BButton.SetActive(false);
			CButton.SetActive(false);
			DButton.SetActive(false);
			
	}
}

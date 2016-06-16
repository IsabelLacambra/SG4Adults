using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;


public class Item {

	[XmlAttribute("numero")]
	public string numero;

	[XmlElement("tipo")]
	public string tipo;

	[XmlElement("imagen")]
	public string imagen;


	[XmlElement("Pregunta")]
	public string pregunta;

	[XmlElement("Correcta")]
	public string correcta;

	[XmlElement("Erronea1")]
	public string erronea1;

	[XmlElement("Erronea2")]
	public string erronea2;

	[XmlElement("Erronea3")]
	public string erronea3;
}

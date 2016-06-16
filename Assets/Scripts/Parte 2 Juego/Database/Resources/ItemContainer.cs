using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Net;

[XmlRoot("ItemCollection")]
public class ItemContainer {



	[XmlArray("Items")]
	[XmlArrayItem("Item")]
	public List<Item> items = new List<Item>();



	public static ItemContainer Load(string path){

		WebClient client = new WebClient();
		
		Stream data = client.OpenRead(@"http://data.sg4adults.cidet.es/items.xml");
		StreamReader reader = new StreamReader(data);
	//	string s = reader.ReadToEnd();
	//	Console.WriteLine(s);

		//**************************************

		//TextAsset _xml = Resources.Load<TextAsset>(path);

		XmlSerializer serializer = new XmlSerializer (typeof(ItemContainer));

		//StringReader reader = new StringReader ();//_xml.text);

		ItemContainer items = serializer.Deserialize (reader) as ItemContainer;

		reader.Close();

		return items;
	}


}

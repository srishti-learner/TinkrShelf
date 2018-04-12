using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShelfManager : MonoBehaviour {

	private string manifestFileName;
	public List<BookObject> bookInfos;

	// load the shelf with data before game starts!
	void Awake () {
		manifestFileName = "Manifests/manifest.json";  //set to passed file name
		LoadShelfData();
	}
	private void LoadShelfData()
	{
		// Path.Combine combines strings into a file path
		//data path is read only
		string filePath = Path.Combine(Application.dataPath, manifestFileName);
		if(File.Exists(filePath))
		{
			// Read the json from the file into a string
			string dataAsJson = File.ReadAllText(filePath); 

			//gets array of json string objects
			string[] allBookJsons = JsonHelper.GetJsonObjectArray(dataAsJson, "books");
		
			int i=0;
			foreach (string jsonObj in allBookJsons)
			{ 
				bookInfos[i++].book = JsonUtility.FromJson<Book>(jsonObj);  //add string object as JSONObject to array of books
				bookInfos[i-1].SetCoverThumbnail();
			}

		}
		else
		{
			Debug.LogError("Cannot load shelf data!");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Serializable objects

[System.Serializable]
public class Book{
	
	public string fileName, pathToThumbnail, title, author, language;
	public int bookId, version, readingLevel;
	public List<string> tags;
}

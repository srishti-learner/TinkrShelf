using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Serializable objects

[System.Serializable]
public class Book{
	
	public string fileName, thumbnail, title, author, language;
	public int bookId, version, readingLevel;
	public string[] tags;
}

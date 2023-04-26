using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	// Use this for initialization
	public void UzSakumu(){
		EditorSceneManager.LoadScene ("Sakums", UnityEngine.SceneManagement.LoadSceneMode.Single);
	}
	public void UzUIElement(){
		EditorSceneManager.LoadScene ("UI elementi", UnityEngine.SceneManagement.LoadSceneMode.Single);
	}
	//Metode , kura aizver programmu, ja tā ir izveidota kā .exe
	public void Apturet(){
		Application.Quit();
	}

}

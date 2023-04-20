using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject BinsIMG;
	public GameObject LacitisIMG;
	public GameObject OmeIMG;
	public GameObject MasinaIMG;

	public GameObject paLabiPoga; //TogglePaLabi
	public GameObject paKreisiPoga;

	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;



	public void binaAttelosana(bool vertiba){
		BinsIMG.SetActive(vertiba);
		paKreisiPoga.GetComponent<Toggle> ().interactable = vertiba;
		paLabiPoga.GetComponent<Toggle> ().interactable = vertiba;
	}
	public void lacitisAttelosana(bool vertiba){
		LacitisIMG.SetActive(vertiba);
	}
	public void omesAttelosana(bool vertiba){
		OmeIMG.SetActive(vertiba);
	}
	public void masinaAttelosana(bool vertiba){
		MasinaIMG.SetActive(vertiba);
	}

	public void paKreisiBins(){
		BinsIMG.transform.localScale = new Vector2(1,1);
	}

	public void paLabiBins(){
		BinsIMG.transform.localScale = new Vector2(-1,1);
	}

	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
		else if (skaitlis == 1)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		else if (skaitlis == 2)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [2];
		else
			Debug.Log ("Nav piesaistīts attēls!");
		
	}
}

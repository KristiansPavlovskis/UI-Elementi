using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VardaParadisana : MonoBehaviour {
	public int kadrSk;
	// Use this for initialization
	void Start () {
		Debug.Log("Uzsākta programma! tu esi "+kadrSk+" kadrā");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("kadrs" + kadrSk);
		kadrSk++;
	}
}

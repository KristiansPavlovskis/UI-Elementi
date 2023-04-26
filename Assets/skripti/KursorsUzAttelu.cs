using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttelu : MonoBehaviour {
	public AudioSource SkanasAvots;
	public AudioClip skanaKoAtskanot;


	public void uzbiditUzAttela(){

		SkanasAvots.PlayOneShot (skanaKoAtskanot);

	}
	public void KursorsNost(){
		SkanasAvots.Stop();
		

	}

}

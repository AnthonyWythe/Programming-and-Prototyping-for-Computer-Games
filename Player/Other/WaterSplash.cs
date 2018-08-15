using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSplash : MonoBehaviour {


    AudioSource waterSound;     //Reference to the splash aduio source


    //Sets up the audio component//
	void Start ()
    {
        waterSound = GetComponent<AudioSource>();
	}


    //If the player enters the water, play the splash sound//
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            waterSound.Play();
        }
    }
}

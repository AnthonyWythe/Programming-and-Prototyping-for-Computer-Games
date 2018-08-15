using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill : MonoBehaviour {

	//Main update method, roates the windmill//
	void Update ()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime)*12);
	}
}

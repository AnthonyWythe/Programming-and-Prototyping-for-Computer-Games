using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

    //Main update method, rotates the coin//
    void Update () {
        transform.Rotate(Vector3.right * (Time.deltaTime) * 24);
    }
}

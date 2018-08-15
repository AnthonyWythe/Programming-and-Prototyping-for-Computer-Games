using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRefresh : MonoBehaviour {

    //References to the NPC markers
    public GameObject marker1;
    public GameObject marker2;
    public GameObject marker3;
    public GameObject marker4;
    public GameObject marker5;
    public GameObject marker6;
    public GameObject marker7;
    public GameObject marker8;
    public GameObject marker9;
    public GameObject marker10;
    public GameObject marker11;
    public GameObject marker12;
    public GameObject marker13;
    public GameObject marker14;
    public GameObject marker15;


    //When called this clears all possible NPC marker points from the map//
    public void ClearMarkers()
    {
        marker1.SetActive(false);
        marker2.SetActive(false);
        marker3.SetActive(false);
        marker4.SetActive(false);
        marker5.SetActive(false);
        marker6.SetActive(false);
        marker7.SetActive(false);
        marker8.SetActive(false);
        marker9.SetActive(false);
        marker10.SetActive(false);
        marker11.SetActive(false);
        marker12.SetActive(false);
        marker13.SetActive(false);
        marker14.SetActive(false);
        marker15.SetActive(false);
    }
}

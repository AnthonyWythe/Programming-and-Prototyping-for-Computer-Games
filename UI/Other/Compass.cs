using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour {

    public Transform player;        //Reference to the players position
    public Texture compBg;          //The compass image
    public Texture blipTex;         //The image for the compass arrow


    //This method draws the compass parts onto the screen//
    private void OnGUI()
    {
        //Draw the compass at 20px from the side, and -175px from the height of the screen (150px * 150px)
        GUI.DrawTexture(new Rect(20, Screen.height - 175, 150, 150), compBg);
        
        //Draw the compass arrow
        GUI.DrawTexture(CreateBlip(), blipTex);
    }


    //This method draws the compass arrow//
    Rect CreateBlip()
    {
        //Compute the position of the player in compass terms
        float angDeg = player.eulerAngles.y - 270;
        float angRed = angDeg * Mathf.Deg2Rad;

        //Generate the x and y positions for the screen
        float blipX = 50 * Mathf.Cos(angRed);
        float blipY = 50 * Mathf.Sin(angRed);

        //Create the arrow, but with adjustments to fit the radius of the circle
        blipX += 65;
        blipY += 65;
        return new Rect(blipX + 20, blipY + (Screen.height - 175), 20, 20);
    }
}

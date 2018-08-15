using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFade : MonoBehaviour
{

    public Image img;       //Reference to the image


    //Call this method when you want the screen to fade
    public void OnButtonClick()
    {
        //Fade out image coroutine
        StartCoroutine(FadeImage(true));
    }


    //The coroutine for the fade out method
    IEnumerator FadeImage(bool fadeAway)
    {
        //Fade from opaque to transparent
        if (fadeAway)
        {
            //Loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        //Fade from transparent to opaque
        else
        {
            //Loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                //Set color with i as alpha
                img.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}
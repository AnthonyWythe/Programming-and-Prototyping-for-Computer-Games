using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsControl : MonoBehaviour {

    public Slider volumeSlider;   //Reference to the volume slider
    public Light sun;             //Reference to the sun object
    public AudioSource music;     //Reference to the music audio source


    //Updates the audio lsitener volume to be the same as the volume slider//
    public void Update()
    {
        AudioListener.volume = volumeSlider.value;
    }


    //Sets the sun to daytime intensity//
    public void DayTime()
    {
        sun.intensity = 1f;
    }
    //Sets the sun to night time intensity//
    public void NightTime()
    {
        sun.intensity = 0.09f;
    }


    //Unpauses the music//
    public void MusicOn()
    {
        music.UnPause();
    }
    //Pauses the music
    public void MusicOff()
    {
        music.Pause();
    }

}

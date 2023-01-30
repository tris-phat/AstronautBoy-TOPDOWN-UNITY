using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip SoundHover;
    public AudioClip  SoundClick;


    public void HoverSound()
    {
        Sound.PlayOneShot(SoundHover);
    }
    public void ClickSound()
    {
        Sound.PlayOneShot(SoundClick);
    }
}

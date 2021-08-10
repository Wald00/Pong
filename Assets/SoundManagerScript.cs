using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip bounceSound;
    static AudioSource audioSrc;

   
    void Start()
    {
        bounceSound = Resources.Load<AudioClip> ("bounce");

        audioSrc = GetComponent<AudioSource> ();
    }


    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "bounce":
            audioSrc.PlayOneShot (bounceSound);

            break;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOptionController : MonoBehaviour
{
    [Header("Sound Effects")]
    public Slider sfxVolume;
    public AudioSource sfx;

    [Header("Music")]
    public Slider musicVolume;
    public AudioSource backgroundMusic;


    public void AdjustSoundEffects()
    {
        sfx.volume = sfxVolume.value;
    }

    public void AdjustMusic()
    {
        backgroundMusic.volume = musicVolume.value;
    }
}

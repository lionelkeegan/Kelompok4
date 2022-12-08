using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource music;
    public AudioSource soundEffect;
    // public AudioSource BGMArea;
    // public AudioSource BGMBoss;
    // public AudioSource BGMSandera;
    // public AudioClip soundWrong;
    // public AudioClip soundCorrect;
    // public AudioClip soundBtnClick;
    // public AudioClip soundBtnDenied;
    private float musicVolume = 1f;
    private float sfxVolume = 1f;
    
    public static SoundManager Instance {get; set; }
   
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;            
            DontDestroyOnLoad(this.gameObject);
        }          
    }


    void Update()
    {
        music.volume = musicVolume;
        soundEffect.volume = sfxVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }

     public void updateVolumeSFX(float volume)
    {
        sfxVolume = volume;
    }


    public void MuteMusic()
    {
        if(music.mute == false)
        {
            music.mute = true;
        }
        else
        {
            music.mute = false;
        }
    }

    public void MuteSFX()
    {
        if(soundEffect.mute == false)
        {
            soundEffect.mute = true;
        }
        else
        {
            soundEffect.mute = false;
        }
    }
    
    
    

    
   
    // void Start()
    // {
        
    // }

    

   

    // public void SoundButton()
    // {
    //     soundEffect.PlayOneShot(soundBtnClick);
    // }

    // public void SoundDenied()
    // {
    //     soundEffect.PlayOneShot(soundBtnDenied);
    // }

}

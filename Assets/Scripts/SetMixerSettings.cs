using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SetMixerSettings : MonoBehaviour
{
    public AudioMixer mixer;

    public Slider sliderMusic;
    public Slider sliderSFX;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("MusicVol"))
            mixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MusicVol"));
        else
        {
            float mVol = 0;
            mixer.GetFloat("MusicVol", out mVol);
            PlayerPrefs.SetFloat("MusicVol", mVol);
        }
        if (PlayerPrefs.HasKey("SFXVol"))
            mixer.SetFloat("SFXVol", PlayerPrefs.GetFloat("SFXVol"));
        else
        {
            float mVol = 0;
            mixer.GetFloat("SFXVol", out mVol);
            PlayerPrefs.SetFloat("SFXVol", mVol);
        }

        if (sliderMusic != null)
        {
            sliderMusic.onValueChanged.AddListener(delegate { SetMusicVol(); });
            if (PlayerPrefs.HasKey("MusicVol"))
                sliderMusic.value = PlayerPrefs.GetFloat("MusicVol");
        }
        if (sliderSFX != null)
        {
            sliderSFX.onValueChanged.AddListener(delegate { SetSFXVol(); });
            if (PlayerPrefs.HasKey("SFXVol"))
                sliderSFX.value = PlayerPrefs.GetFloat("SFXVol");
        }
    }

    void SetMusicVol()
    {
        PlayerPrefs.SetFloat("MusicVol", sliderMusic.value);
        mixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MusicVol"));
    }

    void SetSFXVol()
    {
        PlayerPrefs.SetFloat("SFXVol", sliderSFX.value);
        mixer.SetFloat("SFXVol", PlayerPrefs.GetFloat("SFXVol"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFootsteps : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clips;
    // Update is called once per frame
    void PlayFootstepSoundPls()
    {
        int rand = Random.Range(0, 5);
        audioSource.clip = clips[rand];
        audioSource.Play();
    }
}

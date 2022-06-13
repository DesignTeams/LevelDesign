using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFootsteps : MonoBehaviour
{
    public AudioSource audioSource;
    // Update is called once per frame
    void PlayFootstepSoundPls()
    {
        audioSource.Play();
    }
}

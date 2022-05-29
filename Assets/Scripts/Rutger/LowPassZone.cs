using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LowPassZone : MonoBehaviour
{
    public AudioMixer mixer;
    public float value; //wet mix -80 to 0
    public float volume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ThirdPersonMovement>())
        {
            mixer.SetFloat("LowPass", value);
            mixer.SetFloat("MusicVol", volume);
        }
    }
}

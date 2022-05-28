using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceLights : MonoBehaviour
{
    public AudioSource audioSource;
    public float updateStep = 0.1f;
    public int sampleDataLength = 1024;

    private float currentUpdateTime = 0f;

    public Light l;

    public bool rotX, rotY, rotZ;
    public bool intensity;
    public bool color;

    public float maxIntensity = 1;
    public float colorMulti = 0.1f;
    public Vector3 rotIntensity = new Vector3(1,1,1);
    Vector3 startRot;

    private float clipLoudness;
    private float[] clipSampleData;

    // Use this for initialization
    void Awake()
    {

        if (!audioSource)
        {
            Debug.LogError(GetType() + ".Awake: there was no audioSource set.");
        }
        clipSampleData = new float[sampleDataLength];
        startRot = transform.rotation.eulerAngles;

    }

    // Update is called once per frame
    void Update()
    {

        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples); //I read 1024 samples, which is about 80 ms on a 44khz stereo clip, beginning at the current sample position of the clip.
            clipLoudness = 0f;
            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }
            clipLoudness /= sampleDataLength; //clipLoudness is what you are looking for

            if (rotX) transform.rotation = Quaternion.Euler(startRot + new Vector3(rotIntensity.x, 0, 0) * clipLoudness);
            if (rotY) transform.rotation = Quaternion.Euler(startRot + new Vector3(0, rotIntensity.y, 0) * clipLoudness);
            if (rotZ) transform.rotation = Quaternion.Euler(startRot + new Vector3(0, 0, rotIntensity.z) * clipLoudness);

            if (intensity) l.intensity = maxIntensity * clipLoudness;
            if (color) l.color = Color.HSVToRGB(clipLoudness*colorMulti, 1, 1);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeatTempo : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public float distance;
    public float final;
    public AudioSource source;
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance (player.transform.position, enemy.transform.position);
        Remap(distance, 0, 25, 2.4f, 0.8f);
        source.pitch = final;
    }

    void Remap(float value, float from1, float to1, float from2, float to2) {
        final = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }
}

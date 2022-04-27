using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    public AudioClip song;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<MusicPlayer>().PlaySong(song);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

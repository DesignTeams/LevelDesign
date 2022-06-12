using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject Charlie;
    public GameObject AntonioCam;
    // Start is called before the first frame update
    void Start()
    {
        AntonioCam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slay()
    {
        Charlie.SetActive(false);
        AntonioCam.SetActive(true);
    }
}

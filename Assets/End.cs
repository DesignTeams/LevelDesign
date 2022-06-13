using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public GameObject Charlie;
    public GameObject AntonioCam;
    public RawImage image;
    public Color color;
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
        image.color = color; 
        StartCoroutine(ExecuteAfterTime(5f));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(4);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public GameObject defaultCam;
    public GameObject currentCam;
    List<GameObject> cams = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        cams.Add(defaultCam);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        currentCam = defaultCam;
    }

    public GameObject GetCurrentCam()
    {
        return cams[cams.Count - 1];
    }

    public void AddCamera(GameObject cam)
    {
        cams.Add(cam);
    }

    public void RemoveCamera(GameObject cam)
    {
        cams.Remove(cam);
    }

}

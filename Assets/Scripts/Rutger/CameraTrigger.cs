using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject cam;
    CamManager camManager;
    // Start is called before the first frame update
    void Start()
    {
        camManager = FindObjectOfType<CamManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<ThirdPersonMovement>() != null)
        {
            cam.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<ThirdPersonMovement>() != null)
        {
            cam.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        camManager.currentCam = cam;
    }
}

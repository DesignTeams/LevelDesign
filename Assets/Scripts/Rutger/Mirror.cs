using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public CamManager cm;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = (cm.GetCurrentCam().transform.position - transform.position).normalized;
        Vector3 newDir = Quaternion.AngleAxis(180, transform.forward) * dir;
        Debug.DrawLine(transform.position, transform.position + newDir, Color.green);
        cam.transform.LookAt(transform.position + newDir);
    }
}

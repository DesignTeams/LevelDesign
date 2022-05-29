using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCam : MonoBehaviour
{
    public GameObject player;
    public bool isNPC = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(player.transform.position + Vector3.up);
        if(isNPC)
            transform.Rotate(new Vector3(0, 0, -90), Space.Self);
    }
}

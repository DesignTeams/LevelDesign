using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncers : MonoBehaviour
{
    public Collider col;
    public Animator anim1, anim2;
    public bool allowed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AllowEntrance()
    {
        col.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!allowed) {
            anim1.SetTrigger("Intimidate");
            anim2.SetTrigger("Intimidate");
        }
        else
        {
            anim1.SetTrigger("Dismiss");
            anim2.SetTrigger("Dismiss");
        }
    }
}

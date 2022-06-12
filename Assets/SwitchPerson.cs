using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPerson : MonoBehaviour
{
    public GameObject Charlie;
    public GameObject AntonioCam;
    public GameObject CharlieCam;
    public GameObject camManager;
    // Start is called before the first frame update
    void Start()
    {
        AntonioCam.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            End script = other.GetComponent<End>();
            script.Slay();
        }

        Debug.Log(other.tag);
           
            
            

            //animation
            //the end

        
    }
}

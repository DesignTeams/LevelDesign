using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTrigger : MonoBehaviour
{
    public List<GameObject> objsToEnable, objsToDisable;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<ThirdPersonMovement>() != null)
        {
            foreach(GameObject obj in objsToEnable)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in objsToDisable)
            {
                obj.SetActive(false);
            }
        }
    }

    
}

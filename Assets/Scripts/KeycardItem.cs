using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardItem : Item
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PickUp()
    {
        FindObjectOfType<Bouncers>().AllowEntrance();
        Destroy(gameObject);
    }
}

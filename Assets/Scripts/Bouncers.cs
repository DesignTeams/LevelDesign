using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncers : MonoBehaviour
{
    public GameObject[] humans;
    public Transform player;
    public Collider col;
    public Animator anim1, anim2;
    public bool allowed = false;

    public bool snapToPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(snapToPlayer)
        {
            foreach (GameObject human in humans)
            {
                Vector3 point = player.position;
                point.y = 0;
                Transform NPCS = human.GetComponent<Transform>();
                NPCS.LookAt(Vector3.Lerp(NPCS.position, player.position, 2));

                Animator anim = human.GetComponent<Animator>();
                anim.SetTrigger("Look");
               
                
                
                

                    
            }
        }
        
    }
    
    public void AllowEntrance()
    {
        col.enabled = false;
        snapToPlayer = true;
        
    }
    public void TurnToPlayer(GameObject human)
    {
        Vector3 point = player.position;
        point.y = 0;
        Transform NPCS = human.GetComponent<Transform>();
        NPCS.LookAt(point);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharlieDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject door;
    public EnemyAI charlieAI;
    public Animator CharlieAnim;
    // Start is called before the first frame update
    void Start()
    {
        CharlieAnim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < 20f)
        {
            door.transform.rotation = Quaternion.Euler(0,-dist*1.5f,0);
        }
        else
        {
            charlieAI.enabled = true;
            CharlieAnim.enabled = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateTarget());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }

    IEnumerator UpdateTarget()
    {
        while (true)
        {
            agent.destination = player.transform.position;
            yield return new WaitForSeconds(1);
        }
    }
}

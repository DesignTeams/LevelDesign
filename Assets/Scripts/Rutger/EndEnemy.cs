using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EndEnemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;
    public GameObject deadUI;
    public float minSpeed = 1;
    public float maxSpeed = 4;
    public AnimationCurve speedCurve;

   
    public GameObject AntonioCam;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(UpdateTarget());
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        agent.speed = Mathf.Clamp(speedCurve.Evaluate(Vector3.Distance(transform.position, player.transform.position)), minSpeed, maxSpeed);
    }

    IEnumerator UpdateTarget()
    {
        while (true)
        {
            agent.destination = player.transform.position;
            yield return new WaitForSeconds(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<End>() != null && CompareTag("Player"))
        {
            AntonioCam.SetActive(true);
            End script = other.GetComponent<End>();
            script.Slay();
        }
    }
}

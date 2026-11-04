using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        target = GameObject.FindGameObjectWithTag("Player").transform;

        agent.destination = target.position;
    }

   
    void Update()
    {
        
    }

    
}

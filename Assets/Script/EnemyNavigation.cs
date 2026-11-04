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

       
    }

   
    void Update()
    {
        InvokeRepeating("UpdateTarget", 3f, 2f);
    }

    private void UpdateTarget()
    {
        agent.destination = target.position;
    }

}

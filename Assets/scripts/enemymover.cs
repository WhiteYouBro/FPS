using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMesh))]

public class enemymover : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float radius = 15f;

    private NavMeshAgent agent;
    private float targetdistance;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
    }

    private void Update()
    {
        targetdistance = Vector3.Distance(transform.position, target.transform.position);
        if (targetdistance < radius)
            agent.SetDestination(target.position);
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
#endif
}

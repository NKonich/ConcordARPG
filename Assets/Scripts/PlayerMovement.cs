using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    
    [RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }

    // Update is called once per frame
    public void moveTo (Vector3 point)
    {
        agent.SetDestination(point);
    }

    public void follow(Interactables newTarget)
    {
        target = newTarget.transform;
    }
    public void unfollow()
    {
        target = null;
    }
    void faceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}

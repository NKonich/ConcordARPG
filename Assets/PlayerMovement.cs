using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    
    [RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    public void moveTo (Vector3 point)
    {
        agent.SetDestination(point);
    }
}

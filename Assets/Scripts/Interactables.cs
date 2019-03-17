
using UnityEngine;

public class Interactables : MonoBehaviour { 

    public float radius = 3f;

    void OnDrawnGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}

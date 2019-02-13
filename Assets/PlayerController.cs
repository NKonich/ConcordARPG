using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    [RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
   
    Camera cam;
    PlayerMovement motor;
    public LayerMask moveMask;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, moveMask))
                {
                // Move Player to Target Location
                motor.moveTo(hit.point);
                Debug.Log("We hit" + hit.collider + "at " + hit.point);
                
                }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    private GrapplingHook grappling;
    private Quaternion desiredRotation;
    private float rotationSpeed = 5f;

    void Awake()
    {
        grappling = this.GetComponent<GrapplingHook>();
        
    }



    // Update is called once per frame
    void Update()
    {
        if (!grappling.isGrappling())
        {
            desiredRotation = transform.parent.rotation; 
        }
        else
        {
            desiredRotation = Quaternion.LookRotation(grappling.GetGrapplePoint() - transform.position);           
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * rotationSpeed);
    }
}

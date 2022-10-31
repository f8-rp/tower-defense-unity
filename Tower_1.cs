using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower_1 : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Minion_1 target = hit.transform.GetComponent<Minion_1>();
            if(target != null){
                target.TakeDamage(10f);
            }
        }   
    }

    
}

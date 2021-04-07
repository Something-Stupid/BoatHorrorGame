using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    bool Started;
    public LayerMask LayerMask;

    void Start()
    {
        Started = true;
    }

    void FixedUpdate()
    {
        MyCollisions();
    }

    void MyCollisions()
    {
        //Use OverlapBox to detect if there are any other colliders within this box area
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, LayerMask);

        int i = 0;
        //Check when there is a new colldier coming into contract with the box

        while(i < hitColliders.Length)
        {
            //Output all of the collider names 
            Debug.Log("Hit: " + hitColliders[i].name + i);
            //Increase the number of collisions in the array
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Check that it is being run in play mode so it doesn't draw in editor
        if (Started)
        {
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}

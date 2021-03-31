using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    public Transform enemy;

    Light light;

    private float distanceToEnemy;
    private bool hasBeenTouched;

    void Awake()
    {
        light = gameObject.GetComponent<Light>();
    }

    void FixedUpdate()
    {
        distanceToEnemy = Vector3.Distance(transform.position, enemy.position);


        if(distanceToEnemy < 5.0f)
        {
            float rand = Random.value;
            hasBeenTouched = true;

            if (rand < 0.5)
            {
                light.enabled = false;
            }
            else
            {
                light.enabled = true;
            }
        }
        else if(distanceToEnemy > 5.0f)
        {
            if (hasBeenTouched)
            {
                light.enabled = false;
            }
        }

    }
}

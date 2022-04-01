using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private Transform myTransform;
    public float maxVerticalPosition = 10;
    public float minVerticalPosition = -10;
    public GameObject projectile;


    private void OnEnable()
    {
        myTransform = transform;

    }
    private void Update()
    {
        OutOfBounds(projectile);
        
    }

    public void OutOfBounds(GameObject gameObject)
    {
        if (myTransform.position.y > maxVerticalPosition || myTransform.position.y < minVerticalPosition)
        {
            Destroy(gameObject, 0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(gameObject, 0f);
        }
    }

}

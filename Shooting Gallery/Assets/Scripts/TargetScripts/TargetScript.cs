using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public GameObject target;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(target, 0f);
    }
}

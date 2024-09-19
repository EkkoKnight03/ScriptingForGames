using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_RidgidBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoucyBall : MonoBehaviour
{
    public float bounceForce = 3f;
    public Color newColor = Color.red;
    public float shrinkFactor = 0.9f;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        GetComponent<Renderer>().material.color = newColor;
        transform.localScale *= shrinkFactor;
    }
}

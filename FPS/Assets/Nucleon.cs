using UnityEngine;
using System.Collections;



[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour {

    public float attractionForce;
    Rigidbody body;

    private void Awake()
    {
        Application.targetFrameRate = 60; // using System.Collections 
        body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        body.AddForce(transform.localPosition * - attractionForce);  // distance 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCamera : MonoBehaviour {


    public float rotateSpeed = .5f;

	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

        this.transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed);
        this.transform.LookAt(Vector3.zero);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Script : MonoBehaviour {

     public float rotateSpeed = 1.0f;
     public Vector3 SpinSpeed = Vector3.zero;
     public Vector3 SpinAxis = new Vector3(0, 1, 0);

	// Use this for initialization
	void Start () {

        SpinSpeed = new Vector3(Random.value, Random.value, Random.value);
        SpinAxis = Vector3.up;
        SpinAxis.x = (Random.value - Random.value) * .1f;
	}

	// Update is called once per frame
	void Update () { 

        this.transform.Rotate(SpinSpeed);
        this.transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed);	
	}

    public void SetSize(float size)
    {
        this.transform.localScale = new Vector3(size, size, size);
    }

}

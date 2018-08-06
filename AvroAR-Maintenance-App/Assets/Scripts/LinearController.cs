using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearController : MonoBehaviour {

    public float rate = 1f; //rate at which we travel
    public float distance = 0f;  //lenght of throw of the linear translation
    public enum Orientation { right, up, forward }
    public Orientation orientation;

    //here we lerp between two reference points
    private Vector3 startPoint = new Vector3(0, 0, 0); //starting reference point
    private Vector3 endPoint = new Vector3(0, 0, 0); //ending reference point
    private void Start()
    {
        if (orientation == Orientation.right)
            endPoint = new Vector3(distance, 0, 0); //ending reference point

        if (orientation == Orientation.up)
            endPoint = new Vector3(0, distance, 0); //ending reference point

        if (orientation == Orientation.forward)
            endPoint = new Vector3(0, 0, distance); //ending reference point
        else { }
    }
    void Update()
    {
        transform.localPosition = Vector3.Lerp(startPoint, endPoint, (Mathf.Sin(rate * Time.time) + 1f) / 2f);
    }
}
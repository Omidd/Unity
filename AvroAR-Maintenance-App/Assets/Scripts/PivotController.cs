using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotController : MonoBehaviour
{
    public bool active = false;
    public float speed = 2f;
    //public float maxRotation = 30f;
    public float maxAngle = 90f;
    public float offsetAngle = 0f;
    //public float minAngle = 0f;
    public enum Orientation { right, up, forward }
    public Orientation orientation;
    public bool changeDirection = false;
    //float angleRange;

    private void Start()
    {
        //float angleRange = maxAngle - minAngle;
    }

    //public float degrees;

    void Update()
    {
        if (active)
        {
            if (changeDirection)
            {
                if (orientation == Orientation.right) {
                    transform.localRotation = Quaternion.Euler((maxAngle * Mathf.Sin(Time.time * speed)) + offsetAngle, 0f, 0f);
                }
                if (orientation == Orientation.up) {
                    transform.localRotation = Quaternion.Euler(0f, (maxAngle * Mathf.Sin(Time.time * speed)) + offsetAngle, 0f);
                }
                if (orientation == Orientation.forward){
                    transform.localRotation = Quaternion.Euler(0f, 0f, (maxAngle * Mathf.Sin(Time.time * speed)) + offsetAngle);
                }

                else {
                }
            }
            else
            {
                if (orientation == Orientation.right) {
                    transform.localRotation = Quaternion.Euler(-((maxAngle * Mathf.Sin(Time.time * speed)) + offsetAngle), 0f, 0f);
                }
                if (orientation == Orientation.up) {
                    transform.localRotation = Quaternion.Euler(0f, -((maxAngle * Mathf.Sin(Time.time * speed)) + offsetAngle), 0f);
                }
                if (orientation == Orientation.forward) {
                    transform.localRotation = Quaternion.Euler(0f, 0f, -((maxAngle * Mathf.Sin(Time.time * speed)) + offsetAngle));
                }
                else { 
                }
            }
        }
    }

    public void SetActive()
    {
        active = true;
    }

    public void SetDeactive()
    {
        active = false;
    }
}
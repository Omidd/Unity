using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpAngle : MonoBehaviour
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
                if (orientation == Orientation.right)
                {
                    //float angle = Mathf.LerpAngle(offsetAngle, maxAngle, Time.time * speed * 0.1f);
                    //transform.eulerAngles = new Vector3(angle, 0, 0);
                    //transform.localRotation = Quaternion.Euler(Mathf.LerpAngle(offsetAngle, maxAngle, Time.deltaTime), 0f, 0f);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(maxAngle, transform.localRotation.y, transform.localRotation.z), Time.deltaTime * speed);
                }
                if (orientation == Orientation.up)
                {
                    //float angle = Mathf.LerpAngle(offsetAngle, maxAngle, Time.time * speed * 0.1f);
                    //transform.eulerAngles = new Vector3(0, angle, 0);
                    //transform.localRotation = Quaternion.Euler(0f, Mathf.LerpAngle(offsetAngle, maxAngle, Time.deltaTime), 0f);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, maxAngle, transform.localRotation.z), Time.deltaTime * speed);
                }
                if (orientation == Orientation.forward)
                {
                    //float angle = Mathf.LerpAngle(offsetAngle, maxAngle, Time.time * speed * 0.1f);
                    //transform.eulerAngles = new Vector3(0, 0, angle);
                    //transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.LerpAngle(offsetAngle, maxAngle, Time.deltaTime));
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, maxAngle), Time.deltaTime * speed);
                }
                else
                { }
            }
            else
            {
                if (orientation == Orientation.right)
                {
                    //float angle = Mathf.LerpAngle(offsetAngle, maxAngle, Time.time * speed * 0.1f);
                    //transform.eulerAngles = new Vector3(-angle, 0, 0);
                    //transform.localRotation = Quaternion.Euler(-Mathf.LerpAngle(offsetAngle, maxAngle, Time.deltaTime), 0f, 0f);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(-maxAngle, transform.localRotation.y, transform.localRotation.z), Time.deltaTime * speed);
                }
                if (orientation == Orientation.up)
                {
                    //float angle = Mathf.LerpAngle(offsetAngle, maxAngle, Time.time * speed * 0.1f);
                    //transform.eulerAngles = new Vector3(0, -angle, 0);
                    //transform.localRotation = Quaternion.Euler(0f, -Mathf.LerpAngle(offsetAngle, maxAngle, Time.deltaTime), 0f);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, -maxAngle, transform.localRotation.z), Time.deltaTime * speed);
                }
                if (orientation == Orientation.forward)
                {
                    //float angle = Mathf.LerpAngle(offsetAngle, maxAngle, Time.time * speed * 0.1f);
                    //transform.eulerAngles = new Vector3(0, 0, -angle);
                    //transform.localRotation = Quaternion.Euler(0f, 0f, -Mathf.LerpAngle(offsetAngle, maxAngle, Time.deltaTime));
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, -maxAngle), Time.deltaTime * speed);
                }
                else
                { }
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
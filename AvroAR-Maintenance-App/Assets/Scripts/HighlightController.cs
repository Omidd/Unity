using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightController : MonoBehaviour{

    public float distanceToSee;
    public string ObjectName;
    private Color highlightColor;
    Material originalMaterial, tempMaterial;
    //Material[] originalMaterial, tempMaterial;
    Renderer rend = null;
    public bool active;

    void Start()
    {
        highlightColor = Color.green;
    }


    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            RaycastHit hitInfo;
            Renderer currRend;

            //Draws ray in scene view during playmode; the multiplication in the second parameter controls how long the line will be
            Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

            //A raycast returns a true or false value
            //we  initiate raycast through the Physics class
            //out parameter is saying take collider information of the object we hit, and push it out and 
            //store is in the what I hit variable. The variable is empty by default, but once the raycast hits
            //any collider, it's going to take the information, and store it in whatIHit variable. So then,
            //if I wanted to access something, I could access it through the whatIHit variable. 

            if (Physics.Raycast(this.transform.position, this.transform.forward, out hitInfo, distanceToSee))
            {
                currRend = hitInfo.collider.gameObject.GetComponent<Renderer>();

                if (currRend == rend)
                    return;

                if (currRend && currRend != rend)
                {
                    if (rend)
                    {
                        rend.sharedMaterial = originalMaterial;
                    }

                }

                if (currRend)
                    rend = currRend;
                else
                    return;

                originalMaterial = rend.sharedMaterial;

                tempMaterial = new Material(originalMaterial);
                rend.material = tempMaterial;
                rend.material.color = highlightColor;
            }
            else
            {
                if (rend)
                {
                    rend.sharedMaterial = originalMaterial;
                    rend = null;
                }
            }
        }
        else {
            rend.sharedMaterial = originalMaterial;
            rend = null;
        }
    }

    public void ToggleHighlight()
    {
        active = !active;
    }
}


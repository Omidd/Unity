using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour {

    private int clickCount;
    private bool doubleClick;

	// Use this for initialization
	void Start () {
        clickCount = 0;
        doubleClick = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CountClick()
    {
        if (doubleClick == false)   //true
        {
            clickCount++;
            //yield return new WaitForSeconds(0.1f);
            Debug.Log("Click count: " + clickCount);
            if (clickCount >= 12)
            {
                clickCount = 0;
            }
        }
        else
        { 
            doubleClick = !doubleClick; 
        }
    }

    public int GetClickCount()
    {
        //Debug.Log("Click count: " + clickCount);
        return clickCount;
    }

    public void ResetClickCount()
    {
        clickCount = 0;
    }
}

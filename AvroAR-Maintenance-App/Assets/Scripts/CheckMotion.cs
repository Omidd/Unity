using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMotion : MonoBehaviour {

    //PivotController PivotBase;
    //PivotController PivotShoulder;
    //PivotController PivotElbow;
    //PivotController PivotWrist;
    //PivotController PivotGripper;
    //PivotController PivotPincer1;
    //PivotController PivotPincer2;

    GameObject PivotBase;
    GameObject PivotShoulder;
    GameObject PivotElbow;
    GameObject PivotWrist;
    GameObject PivotGripper;
    GameObject PivotPincer1;
    GameObject PivotPincer2;

    //public bool active;

    private bool isRunning = false;

    // Use this for initialization
    void Start () {
        //Get reference to all pivotable joints
        //GameObject ptrPivotBase     = GameObject.Find("Pivot_Base");
        //GameObject ptrPivotShoulder = GameObject.Find("Pivot_Shoulder");
        //GameObject ptrPivotElbow    = GameObject.Find("Pivot_Elbow");
        //GameObject ptrPivotWrist    = GameObject.Find("Pivot_Wrist");
        //GameObject ptrPivotGripper  = GameObject.Find("Pivot_Gripper");
        //GameObject ptrPivotPincer1  = GameObject.Find("Pivot_Pincer1");
        //GameObject ptrPivotPincer2  = GameObject.Find("Pivot_Pincer2");

        ////Get reference to all PivotController components of pivotable joints
        //PivotBase       = ptrPivotBase.GetComponent<PivotController>();
        //PivotShoulder   = ptrPivotShoulder.GetComponent<PivotController>();
        //PivotElbow      = ptrPivotElbow.GetComponent<PivotController>();
        //PivotWrist      = ptrPivotWrist.GetComponent<PivotController>();
        //PivotGripper    = ptrPivotGripper.GetComponent<PivotController>();
        //PivotPincer1    = ptrPivotPincer1.GetComponent<PivotController>();
        //PivotPincer2    = ptrPivotPincer2.GetComponent<PivotController>();

        //active = false;
}

    // Update is called once per frame
    void Update () {
        //if (active == true)
        //{
        //    MotionCheck();
        //    active = false;
        //}
        //else { }
    }

    public void SetActive()
    {
        //active = true;

        if(isRunning == false)
        {
            MotionCheck();
            //active = false;
        }
        
    }

    private void MotionCheck()
    {
        //PivotShoulder.SetActive();

        isRunning = true;

        PivotShoulder.active = true;
        //yield return new WaitForSeconds(3f);
        //PivotBase.active = true;
        //yield return new WaitForSeconds(2f);
        //PivotShoulder.active = false;
        //PivotBase.active = false;
        //yield return new WaitForSeconds(0.5f);
        //PivotElbow.active = true;
        //yield return new WaitForSeconds(1.5f);
        //PivotGripper.active = true;
        //yield return new WaitForSeconds(1.5f);
        //PivotElbow.active = false;
        //PivotGripper.active = false;
        //yield return new WaitForSeconds(0.5f);
        //PivotPincer1.active = true;
        //PivotPincer2.active = true;
        //yield return new WaitForSeconds(2.5f);
        //PivotPincer1.active = false;
        //PivotPincer2.active = false;

        isRunning = false;
    }
}

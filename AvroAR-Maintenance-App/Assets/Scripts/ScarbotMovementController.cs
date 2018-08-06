// Joshua Kukulsky, February 2018

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarbotMovementController : MonoBehaviour {

    //float init_x = 0f;
    //float init_y = 0f;
    //float init_z = 0f;
    //Vector3 init_v3;
    //public PivotController PivotBase;
    //public PivotController PivotShoulder;
    //public PivotController PivotElbow;
    //public PivotController PivotWrist;
    //public PivotController PivotGripper;
    //public PivotController PivotPincer1;
    //public PivotController PivotPincer2;

    public LerpAngle PivotBase;
    public LerpAngle PivotShoulder;
    public LerpAngle PivotElbow;
    public LerpAngle PivotWrist;
    public LerpAngle PivotGripper;
    public LerpAngle PivotPincer1;
    public LerpAngle PivotPincer2;

    // Use this for initialization
    void Start () {

        ////Get reference to all pivotable joints
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

        //PivotBase.active = true;  //enables pivoting of base joint

        //init_v3.x = 0f;
        //init_v3.y = 0f;
        //init_v3.z = 0f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartPivot(PivotController joint)
    {
        //init_x = joint.transform.eulerAngles.x;
        //init_y = joint.transform.eulerAngles.y;
        //init_z = joint.transform.eulerAngles.z;
        //init_v3.x = init_x;
        //init_v3.y = init_y;
        //init_v3.z = init_z;

        joint.active = true;
    }

    public void StopPivot(PivotController joint)
    {
        joint.active = false;

        //joint.transform.eulerAngles = AngleLerp(joint.transform.rotation.eulerAngles, init_v3, Time.deltaTime);

        //joint.transform.eulerAngles = init_v3;
    }

    public void TogglePivot(PivotController joint)
    {
        joint.active = !joint.active;
    }

    public void StartMotionCheck()
    {
        //joint.active = !joint.active;
        //PivotBase = Base;
        //PivotShoulder = Shoulder;
        //PivotElbow = Elbow;
        //PivotWrist = Wrist;
        //PivotGripper = Gripper;
        //PivotPincer1 = Pincer1;
        //PivotPincer2 = Pincer2;
        StartCoroutine(MotionCheck(PivotBase, PivotShoulder, PivotElbow, PivotWrist, PivotGripper, PivotPincer1, PivotPincer2));
    }

    //IEnumerator MotionCheck(PivotController Base, PivotController Shoulder, PivotController Elbow, PivotController Wrist, PivotController Gripper, PivotController Pincer1, PivotController Pincer2)
    IEnumerator MotionCheck(LerpAngle Base, LerpAngle Shoulder, LerpAngle Elbow, LerpAngle Wrist, LerpAngle Gripper, LerpAngle Pincer1, LerpAngle Pincer2)
    {
        //while (true)
        //{
            Shoulder.active = true;
            yield return new WaitForSeconds(4f);
            Base.active = true;
            yield return new WaitForSeconds(11f);
            Shoulder.active = false;
            Base.active = false;
            yield return new WaitForSeconds(0.5f);
            Elbow.active = true;
            yield return new WaitForSeconds(4.5f);
            Gripper.active = true;
            yield return new WaitForSeconds(5.5f);
            Elbow.active = false;
            Gripper.active = false;
            yield return new WaitForSeconds(0.5f);
            Wrist.active = true;
            yield return new WaitForSeconds(3.5f);
            Wrist.active = false;
            yield return new WaitForSeconds(0.5f);
            Pincer1.active = true;
            Pincer2.active = true;
            yield return new WaitForSeconds(4.5f);
            Pincer1.active = false;
            Pincer2.active = false;

            //yield return 0;
        //}
    }



    //PivotController joint, PivotController joint, PivotController joint, PivotController joint, PivotController joint, PivotController joint, PivotController joint
    //Vector3 AngleLerp(Vector3 StartAngle, Vector3 FinishAngle, float t)
    //{
    //    float xLerp = Mathf.LerpAngle(StartAngle.x, FinishAngle.x, t);
    //    float yLerp = Mathf.LerpAngle(StartAngle.y, FinishAngle.y, t);
    //    float zLerp = Mathf.LerpAngle(StartAngle.z, FinishAngle.z, t);
    //    Vector3 Lerped = new Vector3(xLerp, yLerp, zLerp);
    //    return Lerped;
    //}
}

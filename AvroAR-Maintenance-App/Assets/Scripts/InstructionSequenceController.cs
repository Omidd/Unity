

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionSequenceController : InstructionArray<GameObject>
{

    // instruction we are currently at
    private GameObject CurrentInstruction;

    // instruction to change to
    private GameObject TargetInstruction;

    protected override void Start()
    {
        //mColorTransition = TargetObject.GetComponent<ColorTransition>();
        base.Start();
    }

    /// <summary>
    /// Select the color from the Array and apply it.
    /// </summary>
    /// <param name="index"></param>
    public override void SetIndex(int index)
    {
        base.SetIndex(index);

        if ((Index - 1) >= 0)
        {
            CurrentInstruction = Array[Index - 1];
            TargetInstruction = Array[Index];

            CurrentInstruction.SetActive(false);
            TargetInstruction.SetActive(true);
        }
        else
        {
            //CurrentInstruction = Array[Index - 1];
            TargetInstruction = Array[Index];

            //CurrentInstruction.SetActive(false);
            TargetInstruction.SetActive(true);
        }
        

        //if (mColorTransition == null)
        //{
        //    Renderer renderer = TargetObject.GetComponent<Renderer>();

        //    if (renderer != null)
        //    {
        //        mMaterial = renderer.material;
        //    }

        //    mMaterial.color = mTargetColor;
        //}
        //else
        //{
        //    mColorTransition.StartTransition(mTargetColor);
        //}
    }

    /// <summary>
    /// clean up material if one was created dynamically
    /// </summary>
    //private void OnDestroy()
    //{
    //    if (mMaterial != null)
    //    {
    //        GameObject.Destroy(mMaterial);
    //    }
    //}

}


//   //GameObject WorkTask;
//   public GameObject CurrentInstruction;
//   //GameObject NextInstruction;
//   //public bool isTask_001209;
//   //public bool isTask_001310;
//   //WorkTaskController WorkTaskController;
//   public int instructionListCount;
//   public int instructionListPair = 2;
//   public GameObject[] InstructionPair;
//   public GameObject[] InstructionList;


//   // Use this for initialization
//   void Start () {
//       //isTask_001209 = false;
//       //isTask_001310 = false;
//       //String CurrentTask = WorkTaskController.GetCurrentTask();


//   }

//// Update is called once per frame
//void Update () {
//       //WorkTask = GameObject.Find("WorkTasks");
//       //isTask_001209 = WorkTask.Task_001209;
//   }

//   public void GoToNextInstruction(GameObject NextInstruction)
//   {
//       CurrentInstruction.SetActive(false);
//       NextInstruction.SetActive(true);
//       CurrentInstruction = NextInstruction;
//   }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAssemblyIntructionLinker : MonoBehaviour {

    public GameObject WorkInstruction;
    public GameObject AssemblyInstruction;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (WorkInstruction.activeSelf == true)
        {
            AssemblyInstruction.SetActive(true);
        }
    }

    //public void isActive()
    //{
    //    if(WorkInstruction.activeSelf == true)
    //    {
    //        AssemblyInstruction.SetActive(true);
    //    }
    //}
}

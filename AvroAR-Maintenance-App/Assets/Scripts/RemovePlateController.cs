using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlateController : MonoBehaviour {

    public GameObject ScrewPlate;
    public bool active;

	// Use this for initialization
	void Start () {
        //ScrewPlate = GameObject.Find("ScrewPlate"); //tag of screwPlate in assembly. we hide it because we have a screw plate in the instruction assembly
        ScrewPlate.SetActive(active);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

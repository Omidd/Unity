using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTensionerController : MonoBehaviour {

    public GameObject Tensioner;
    public bool active;

    // Use this for initialization
    void Start()
    {
        //ScrewPlate = GameObject.Find("ScrewPlate"); //tag of screwPlate in assembly. we hide it because we have a screw plate in the instruction assembly
        Tensioner.SetActive(active);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorkOrderController : MonoBehaviour {

    public string nextScene;
    GameObject WorkOrderMenu;

    // Use this for initialization
    void Start()
    {
        WorkOrderMenu = GameObject.Find("WorkOrderMenu");
        WorkOrderMenu.SetActive(true);
    }
    
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenWorkOrder()
    {
        WorkOrderMenu.SetActive(false);
        SceneManager.LoadScene(nextScene);
    }
}

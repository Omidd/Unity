using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignageController : MonoBehaviour {

    public Image signage;
    public bool active = false;

    // Use this for initialization
    IEnumerator Start () {
        signage.canvasRenderer.SetAlpha(0.0f); //set transparent to start

        while (active)
        {
            signage.CrossFadeAlpha(1.0f, 1.5f, false); //fade sign in
            yield return new WaitForSeconds(0.5f);
            signage.CrossFadeAlpha(0.0f, 2.5f, false); //fade sign out
            yield return new WaitForSeconds(0.5f);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

public class TaskController : MonoBehaviour {

    private TextToSpeech textToSpeech;

    public GameObject TaskChooseText;
    public GameObject TaskCompletedText;
    public GameObject Task001209;
    public GameObject Task001310;

	// Use this for initialization
	void Start () {
        textToSpeech = GetComponent<TextToSpeech>();
        TaskChooseText.SetActive(true);
        TaskCompletedText.SetActive(false);
        Task001209.SetActive(false);
        Task001310.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnableTask001209()
    {
        // Create message
        var msg = string.Format(
        "Activating guidance to adjust shoulder belt tension.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg);

        TaskChooseText.SetActive(false);
        TaskCompletedText.SetActive(false);
        Task001209.SetActive(true);
        Task001310.SetActive(false);
    }

    public void EnableTask001310()
    {
        // Create message
        var msg = string.Format(
        "Activating guidance to recallibrate wrist joint.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg);

        TaskChooseText.SetActive(false);
        TaskCompletedText.SetActive(false);
        Task001209.SetActive(false);
        Task001310.SetActive(true);
    }


    //the following simulate completed tasks
    public void EnableTask001180()
    {
        // Create message
        var msg = string.Format(
        "Visual inspection already completed.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg);

        TaskChooseText.SetActive(false);
        TaskCompletedText.SetActive(true);
        Task001209.SetActive(false);
        Task001310.SetActive(false);
    }

    public void EnableTask001201()
    {
        // Create message
        var msg = string.Format(
        "System self-check already completed.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg);

        TaskChooseText.SetActive(false);
        TaskCompletedText.SetActive(true);
        Task001209.SetActive(false);
        Task001310.SetActive(false);
    }

    public void EnableTask001204()
    {
        // Create message
        var msg = string.Format(
        "Wrist joint recallibration already completed.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg);

        TaskChooseText.SetActive(false);
        TaskCompletedText.SetActive(true);
        Task001209.SetActive(false);
        Task001310.SetActive(false);
    }




}

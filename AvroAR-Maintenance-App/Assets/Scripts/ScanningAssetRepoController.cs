using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using HoloToolkit.Unity;

public class ScanningAssetRepoController : MonoBehaviour
{
    public Text Message1;
    public Text Message2;
    public GameObject Logo;
    public string nextScene;
    GameObject ScanningText;

    private TextToSpeech textToSpeech;

    IEnumerator Start()
    {
        textToSpeech = GetComponent<TextToSpeech>();

        // Create message
        var msg1 = string.Format(
        "Scanning the asset repository.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg1);

        ScanningText = GameObject.Find("ScanningText");
        ScanningText.SetActive(true);

        Message1.canvasRenderer.SetAlpha(0.0f); //set to transparent in order to fade in next
        Message2.canvasRenderer.SetAlpha(0.0f);

        //the following fades in and out the text to resemble a query to the asset repo

        Message1.CrossFadeAlpha(1.0f, 1f, false); //fade into scene
        yield return new WaitForSeconds(1.5f);
        Message1.CrossFadeAlpha(0.0f, 1f, false); //fade out of scene
        yield return new WaitForSeconds(1f);

        Message1.CrossFadeAlpha(1.0f, 1f, false); //fade into scene
        yield return new WaitForSeconds(1.5f);
        Message1.CrossFadeAlpha(0.0f, 1f, false); //fade out of scene
        yield return new WaitForSeconds(1f);

        // Create message
        var msg2 = string.Format(
        "Downloading assets.",
        textToSpeech.Voice.ToString());
        // Speak message
        textToSpeech.StartSpeaking(msg2);

        Message2.CrossFadeAlpha(1.0f, 1f, false); //fade into scene
        yield return new WaitForSeconds(1.5f);
        Message2.CrossFadeAlpha(0.0f, 1f, false); //fade out of scene
        yield return new WaitForSeconds(1f);

        Message2.CrossFadeAlpha(1.0f, 1f, false); //fade into scene
        yield return new WaitForSeconds(1.5f);
        Message2.CrossFadeAlpha(0.0f, 1f, false); //fade out of scene
        yield return new WaitForSeconds(1f);

        ScanningText.SetActive(false);
        Logo.SetActive(true);
        //yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(nextScene);
    }
}

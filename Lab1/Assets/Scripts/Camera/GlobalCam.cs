using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCam : MonoBehaviour
{
    //References to all the "cinematic" cameras in the scene
    public GameObject zombieCam;
    public GameObject safeHouseCam;
    public GameObject dollyCam;

    //Reference to the main text
    public Text mainText;

    // Start is called before the first frame update
    void Start()
    {
        //Set all the cinematic cameras to deactive and clear the text from the screen
        zombieCam.SetActive(false);
        safeHouseCam.SetActive(false);
        dollyCam.SetActive(false);
        mainText.text = "";
        StartCoroutine(camTransition());
    }

    IEnumerator camTransition()
    {
        yield return new WaitForSeconds(3);
        //After waiting 3 seconds, set the zombie camera to true and display the text
        zombieCam.SetActive(true);
        mainText.text = "Help Unity Chan Run Away From the Zombie!";

        yield return new WaitForSeconds(3);
        //After 3 more seconds, deactivate zombie camera and clear text
        zombieCam.SetActive(false);
        mainText.text = "";

        //Activate the safe house camera and display the new message
        safeHouseCam.SetActive(true);
        mainText.text = "Get To the Safe House to Win!";

        //Wait 3 seconds then deactivate the safe house camera and clear text.
        yield return new WaitForSeconds(3);
        safeHouseCam.SetActive(false);
        mainText.text = "";
    }
}

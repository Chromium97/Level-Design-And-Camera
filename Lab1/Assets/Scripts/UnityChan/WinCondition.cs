using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{

    //References to unity chan and zombie characters
    public GameObject unityChan;
    public GameObject zombie;

    //Refernce to canvas and text element
    public Text mainText;

    private void OnTriggerEnter(Collider other)
    {
        //If unity chan collides with the end box then destroy all characters and display the win condition message.
        if (other.gameObject.name == "unitychan")
        {
            Destroy(unityChan, 1.0f);
            Destroy(zombie, 1.0f);

            mainText.text = "You Win! Unity Chan is Safe!";
        }
    }
}

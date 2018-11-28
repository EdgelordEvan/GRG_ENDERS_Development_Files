using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{

    public static bool inRange;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "EdgelordTrig")
        {
            inRange = true;
            Debug.Log("I see you!");
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "EdgelordTrig")
        {
            inRange = false;
            Debug.Log("Where are you?");
        }
    }
}


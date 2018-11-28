using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer2 : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Edgelord")
        {
            HP_Script.health -= 1f;
        }
    }
}

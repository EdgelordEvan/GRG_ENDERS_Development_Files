﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneGRG : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Edgelord")
        {
            SceneManager.LoadScene("GRG House");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

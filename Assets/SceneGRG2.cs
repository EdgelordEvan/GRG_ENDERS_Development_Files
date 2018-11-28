using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneGRG2 : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Edgelord")
        {
            SceneManager.LoadScene("Boss Room");
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

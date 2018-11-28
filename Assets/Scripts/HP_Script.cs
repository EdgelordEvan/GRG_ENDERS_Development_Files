using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP_Script : MonoBehaviour {

    Image healthBar; //= GameObject.Find("HP").GetComponent<Image>()
    float maxHealth = 300f;
    public static float health;
    int lives = 3;
    



	// Use this for initialization
	void Start () {
        //healthBar = GetComponent<Image>();
        GameObject imageObject = GameObject.FindGameObjectWithTag("HP");
        if (imageObject != null)
        {
            healthBar = imageObject.GetComponent<Image>();
        }
        health = maxHealth;

    }

    // Update is called once per frame
    void Update () {
        healthBar.fillAmount = health / maxHealth;
        if (lives > 0)
        {
            if (health < 1)
            {
                //healthBar.fillAmount = maxHealth;
                //GameObject.Find("Edgelord").GetComponent<Transform>().transform.position = new Vector2(15.2f, 0.5973954f);
                lives -= 1;
                
                
            }
        }
        else if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
	}
}

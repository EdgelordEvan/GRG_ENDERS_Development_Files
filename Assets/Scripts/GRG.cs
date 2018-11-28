using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GRG : MonoBehaviour
{
    Image ghealthbar;
    public int Health;
    public static int MaxHealth = 100;
    public static bool Knockback;
    public int spawn = 0;
    public int spawn2 = 0;
    public int spawn3 = 0;
    public int spawn4 = 0;
    public int spawn5 = 0;
    public int halfway = 0;
    public GameObject GREGORY;
    public GameObject Flames;
    public Vector2 Flames1;
    public Vector2 Flames2;
    public Vector2 GRG1;
    public Vector2 GRG2;
    public int check;
    //public GameObject yeef;

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "TRANSCEND")
        {
            GameObject imageObject = GameObject.FindGameObjectWithTag("GRGHPFRONT");
            if (imageObject != null)
            {
                ghealthbar = imageObject.GetComponent<Image>();
                
            }
            Debug.Log(Health);
            check = Health;
            ghealthbar.fillAmount = check / 100;
        }
        if (Health == 85)
        {
            for (int i = spawn; i < 1; i++)
            {
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                spawn++;
            }
        }
        if (Health == 70)
        {
            for (int i = spawn2; i < 1; i++)
            {
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                spawn2++;
            }
        }
        if (Health == 55)
        {
            for (int i = spawn3; i < 1; i++)
            {
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                spawn3++;
            }
        }
        if (Health == 45)
        {
            for (int i = spawn4; i < 1; i++)
            {
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                spawn4++;
            }
        }
        if (Health == 30)
        {
            for (int i = halfway; i < 1; i++)
            {
                Instantiate(GREGORY, GRG1, Quaternion.identity);           
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                //TRANSCEND.periodMultiplier = 4;
                Destroy(GameObject.Find("GRG FACE"));
                Destroy(GameObject.Find("FLOOR"));
                Destroy(GameObject.Find("GRG FACE (2)"));
                Destroy(GameObject.Find("GRG FACE (3)"));
                Destroy(GameObject.Find("GRG FACE (4)"));
                gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 32.7f);
                halfway++;
            }
        }
        if (Health == 10)
        {
            for (int i = spawn5; i < 1; i++)
            {
               // TRANSCEND.periodMultiplier = 6;
                spawn5++;
                Instantiate(GREGORY, GRG1, Quaternion.identity);
                Instantiate(GREGORY, GRG2, Quaternion.identity);
                Instantiate(Flames, Flames1, Quaternion.identity);
                Instantiate(Flames, Flames2, Quaternion.identity);
            }
        }
            if (Health <= 0)
            {
                if (gameObject.name == "TRANSCEND")
                {
                SceneManager.LoadScene("Win");
                }
                else
                {
                    Destroy(gameObject);
                }
            }
            // if (EdgeAttack.bloof)
            // {
            //     Instantiate(yeef, transform.position, Quaternion.identity);
            //}
            if (gameObject.name != "TRANSCEND")
            {
                if (Knockback == true && gameObject.transform.position.x < GameObject.Find("Edgelord").transform.position.x)
                {
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x - 3, gameObject.transform.position.y);
                }
                else if (Knockback == true && gameObject.transform.position.x > GameObject.Find("Edgelord").transform.position.x)
                {
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x + 3, gameObject.transform.position.y);
                }
                else
                {
                    gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
                }
            }


        }



    }


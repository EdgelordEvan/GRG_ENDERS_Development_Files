using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRGAI : MonoBehaviour {

    public float GRGSpeed;
    public float GRGDamage;
    private Transform EdgeTarget;
    public Animator anim;
    public SpriteRenderer spr_renderer;
    

    private void Start()
    {
        EdgeTarget = GameObject.FindGameObjectWithTag("Edgelord").GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update () {
        if (Sender.inRange == true)
        {
            gameObject.transform.position = Vector2.MoveTowards(transform.position, EdgeTarget.position, GRGSpeed * Time.deltaTime);
            anim.SetBool("Sighted", true);
            if (gameObject.GetComponent<Transform>().position.x > GameObject.FindGameObjectWithTag("Edgelord").GetComponent<Transform>().position.x)
            {
                spr_renderer.flipX = false;
            }
            else
            {

                spr_renderer.flipX = true;
            }
        }
        else
        {
            anim.SetBool("Sighted", false);
        }

        //GRGSight();

        //transform.position = Vector2.MoveTowards(transform.position, EdgeTarget.position, GRGSpeed * Time.deltaTime);
    }


   /* private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "EdgelordTrig")
        {*/
        


        //}
   // }


  /*  public void GRGSight()
    {
        if (GameObject.Find("GRG AI").GetComponent<CircleCollider2D>().bounds.Intersects(GameObject.Find("EdgelordTrigger").GetComponent<CircleCollider2D>().bounds))
        {
            transform.position = Vector2.MoveTowards(transform.position, EdgeTarget.position, GRGSpeed * Time.deltaTime);
            anim.SetBool("Sighted", true);
            if (GameObject.FindGameObjectWithTag("GRG").GetComponent<Transform>().position.x > GameObject.FindGameObjectWithTag("Edgelord").GetComponent<Transform>().position.x)
            {
                spr_renderer.flipX = false;
            }
            else
            {
                spr_renderer.flipX = true;
            }
        }

        else
        {
            anim.SetBool("Sighted", false);
        }
    }*/
}

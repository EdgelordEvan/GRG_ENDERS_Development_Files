using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeAttack : MonoBehaviour {

    private float TimeBetweenAttack;
    public float StartTimeBetweenAttack;
    public Animator Eanimator;
    public Transform EdgeAttackPos;
    public LayerMask Greg;
    //public Animator CameraAnimation;
    public float EdgeRange;
    public int EdgeDamage;
    public static bool bloof;
   // public GRG gregscript = new GRG();


    // Update is called once per frame
    void Update () {
        if (TimeBetweenAttack <= 0) //Can attack
        {
            if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.J))
            {
                TimeBetweenAttack = StartTimeBetweenAttack;
                
                Eanimator.SetBool("Punch", true);
                //CameraAnimation.SetTrigger("Shake");
                Collider2D[] GRGsToDamage = Physics2D.OverlapCircleAll(EdgeAttackPos.position, EdgeRange, Greg);
                for (int i = 0; i < GRGsToDamage.Length; i++)
                {
                    bloof = true;
                   GRGsToDamage[i].GetComponent<GRG>().Health -= EdgeDamage;
                    GRG.Knockback = true;
                }

            }
            
        }
        else
        {
            bloof = false;
            GRG.Knockback = false;
            Eanimator.SetBool("Punch", false);
            TimeBetweenAttack -= Time.deltaTime;
        }
        //if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.J))
        //{ }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(EdgeAttackPos.position, EdgeRange);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EdgeMove : MonoBehaviour {

    private Rigidbody2D Edgeplayer;
    public Animator EdgeAnimator;
    public SpriteRenderer EdgeRenderer;
    // public LayerMask IsGround;
    public EdgeAttack EdgeScript;
    public PauseMenu Menu;
    public float EdgeSpeed;
    public float EdgeJump;
    bool EdgeGrounded = false;
    bool EdgeCrouch = false;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;
    // Use this for initialization
    void Start() {
        Edgeplayer = GetComponent<Rigidbody2D>();
       
    }
	
	
	void Update() {

        
            DownCheck();

            if (EdgeCrouch == false)
            {
                float X_Move = Input.GetAxisRaw("Horizontal");
                Movement(X_Move);
                Jump();
                EdgeAnimator.SetFloat("Speed", Mathf.Abs(X_Move));
                if (X_Move < 0)
                {
                    EdgeRenderer.flipX = true;
                    GameObject.Find("AttackRange").transform.position = new Vector2(GameObject.Find("Edgelord").transform.position.x - 2, GameObject.Find("Edgelord").transform.position.y);
                }
                else
                {
                    EdgeRenderer.flipX = false;
                    GameObject.Find("AttackRange").transform.position = new Vector2(GameObject.Find("Edgelord").transform.position.x + 2, GameObject.Find("Edgelord").transform.position.y);
                }


                // Debug.Log(EdgeGrounded);
            }
        
        
    }

    private void Movement(float X_Move)
    {
       
            Edgeplayer.velocity = new Vector2(X_Move * EdgeSpeed, Edgeplayer.velocity.y);
        
    
    }
    private void Jump()
    {      
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                if (EdgeGrounded)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, EdgeJump);
                }
            }
        
    }

    public void DownCheck()
    {
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                EdgeAnimator.SetBool("Down", true);
                EdgeCrouch = true;

            }
            else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
            {
                EdgeAnimator.SetBool("Down", false);
                EdgeCrouch = false;
            }
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Ground")
        {
            EdgeGrounded = true;
            EdgeAnimator.SetBool("Jump", false);
        }
        if (col.tag == "DeathBox")
        {
         
            GameObject.Find("Edgelord").GetComponent<Transform>().transform.position = new Vector2(15.2f, 0.5973954f);
            HP_Script.health -= 5;
            Debug.Log("DIE");
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Ground")
        {
            EdgeGrounded = false;
            EdgeAnimator.SetBool("Jump", true);
        }
    }

}


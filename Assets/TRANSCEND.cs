using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRANSCEND : MonoBehaviour {


    public float amplitude;
    public static float periodMultiplier = 2;
    public float upamplitude;
    public float upperiodMultiplier;

    public float health = 50f;

    public Rigidbody2D body;

    private float t0;

    // Use this for initialization
    void Start () {
        t0 = Time.time;

        this.body = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        this.body.velocity = amplitude * Mathf.Cos(periodMultiplier * (Time.time - t0)) * Vector2.right;
        
    }
}

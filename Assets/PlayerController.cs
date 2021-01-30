using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController playerInstance;
    private Rigidbody2D rbody;
    private Animator animator;
    public float force = 100;
    // public float speed = 10;
    public int health = 3;

    private void Awake() {
        playerInstance = this;
        rbody = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // rbody.velocity = transform.right * speed;
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            rbody.velocity = transform.up * force;
        }

        if(health <= 0)
        {
            animator.SetInteger("Animation", 1);
            Debug.Log("You are Dead!");
        }
    }
}

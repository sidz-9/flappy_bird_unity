using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float speed = -10;

    private void Awake() 
    {
        rbody = this.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rbody.velocity = transform.right * speed * Time.deltaTime;   // Time.deltaTime giving issues
        // rbody.velocity = new Vector2(speed, 0.0f);   // can use this also
        rbody.velocity = transform.right * speed;
    }
}

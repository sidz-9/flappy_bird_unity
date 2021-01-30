using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collisioin)
    {
        if(collisioin.gameObject.tag == "Player") 
        {
            PlayerController.playerInstance.health -= 1;
            // Debug.Log("Health is " + PlayerController.playerInstance.health);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

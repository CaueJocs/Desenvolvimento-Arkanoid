using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D body;
    private float speed = 150f; 
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

   
    void Update () {
            
   
    }

    private void FixedUpdate()
    {
        if(GameManager.instance.gameState == GameState.Play)
        { 
        float h = Input.GetAxis("Horizontal");
        body.linearVelocity = Vector2.right * h * speed;
        }

    }
}

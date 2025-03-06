using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BallScript : MonoBehaviour
{
    private float speed = 100f;
    private Rigidbody2D body;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {

    }

    public void StartBall()
    {
        body = GetComponent<Rigidbody2D>();
        body.linearVelocity = Vector2.zero;
        body.linearVelocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float HitFactor(Vector2 ball, Vector2 player, float playerWidth)
    {
        return (ball.x - player.x) / playerWidth;
    }

    void OnCollisionEnter2D(Collision2D coll){
    if (coll.gameObject.tag == "Brick"){
        GameManager.instance.AddPoints(10);
        Destroy(coll.gameObject);  
    }
    else if (coll.gameObject.name == "border_bottom_0"){
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Cena_2"){
            SceneManager.LoadScene("Cena_3");
        } else if(scene.name == "Cena_4"){
            SceneManager.LoadScene("Cena_3");
        }   
    }
    else if (coll.gameObject.tag == "Player"){
        float x = HitFactor(transform.position, coll.transform.position, coll.collider.bounds.size.x);

        Vector2 dir = new Vector2(x,1).normalized;

        body.linearVelocity = dir * speed; 
    }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    private bool moveRight = true;
    private SpriteRenderer render;
    public float movementSpeed = 4.0f;
    public GameObject car_1;
    
    void Start(){
        
    }

    void Awake(){
        render = GetComponent<SpriteRenderer>();
    }
    
    void Update(){

        if (moveRight) {
            transform.Translate (Vector2.right * movementSpeed * Time.deltaTime);
        }
        else {
            transform.Translate (-Vector2.right * movementSpeed * Time.deltaTime);
        }

        if (transform.position.x >= 16.0f) {
            moveRight = false;
            render.flipX = !render.flipX;
        }

        if (transform.position.x <= -16.0f) {
            moveRight = true;
            render.flipX = !render.flipX;
        }
    }
}

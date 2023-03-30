using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    

    private float moveInput;
    private Rigidbody2D rb;
    public Sprite blueCube;
    public Sprite greenCube;




    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }


    public void pushLeft(float pushForce) {
        rb.velocity = new Vector2(rb.velocity.x-pushForce , rb.velocity.y);
        Debug.Log("working");
    }

    public void pushRight(float pushForce) {
        rb.velocity = new Vector2(rb.velocity.x+pushForce, rb.velocity.y);
        Debug.Log("working");
    }

    public void pushUp(float pushForce) {
        rb.velocity = new Vector2(rb.velocity.x , rb.velocity.y + pushForce);
        Debug.Log("working");
    }
    public void pushDown(float pushForce) {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - pushForce);
        Debug.Log("working");
    }

    public void blueOrGreen()
    {
        if(this.GetComponent<SpriteRenderer>().sprite == greenCube)
        {
            this.GetComponent<SpriteRenderer>().sprite = blueCube;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = greenCube;
        }
        
        
    }


    public void defaultColor() {
        this.GetComponent<SpriteRenderer>().sprite = greenCube;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.A)) {
            pushLeft(10);
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    private Collider2D pongC;
    private Rigidbody2D pongRB;
    private Vector2 pongDirection;

    public bool spacesPress;
    public int giveScoreLeft;
    public int giveScoreRight;

    // Start is called before the firSst frame update
    void Start()
    {
        pongRB = GetComponent<Rigidbody2D>();
        pongC = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!spacesPress && Input.GetKey(KeyCode.Space))
        {
            float x = -3;
            float y = -3;
            pongDirection = new Vector2 (x, y);
            pongRB.AddForce(pongDirection, ForceMode2D.Impulse);
            spacesPress = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Score Left"))
        {
            giveScoreLeft ++;
            pongRB.velocity = new Vector2(0, 0f);
            transform.position = new Vector3(5f, 0f, 0f);
            spacesPress = false;
        }

        if(collision.gameObject.CompareTag("Score Right"))
        {
            giveScoreRight++;
            pongRB.velocity = new Vector2(0, 0f);
            transform.position = new Vector3(-5f, 0f, 0f);
            spacesPress = false;
        }
    }
    
        

    }

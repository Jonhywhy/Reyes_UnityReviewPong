using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour
{
    private Collider2D pongC;
    private Rigidbody2D pongRB;
    private SpriteRenderer pongRenderer;
    private Vector2 pongDirection;


    public bool spacesPress;
    public bool score;
    public bool scoreRight;
    public bool scoreLeft;
    public int giveScoreLeft;
    public int giveScoreRight;
    public float addSpeed;

    // Start is called before the firSst frame update
    void Start()
    {
        pongRenderer = GetComponent<SpriteRenderer>();
        pongRB = GetComponent<Rigidbody2D>();
        pongC = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        int[] random = new int [6];
         random[0] = 6;
         random[1] = 7;
         random[2] = 8;
         random[3] = -6;
         random[4] = -7;
         random[5] = -8;

        

        if (!spacesPress && Input.GetKey(KeyCode.Space) && !score)
        {
            float x = random[Random.Range(0, random.Length)];
            float y = random[Random.Range(0, random.Length)];
            pongDirection = new Vector2 (x, y);
            pongRB.AddForce(pongDirection, ForceMode2D.Impulse);
            spacesPress = true;
        }
        if(!spacesPress && Input.GetKey(KeyCode.Space) && scoreRight)
        {
            float x = -6;
            float y = random[Random.Range(0, random.Length)];
            pongDirection = new Vector2(x, y);
            pongRB.AddForce(pongDirection, ForceMode2D.Impulse);
            spacesPress = true;
        }

        if (!spacesPress && Input.GetKey(KeyCode.Space) && scoreLeft)
        {
            float x= 6;
            float  y = random[Random.Range(0, random.Length)];
            pongDirection = new Vector2(x, y);
            pongRB.AddForce(pongDirection, ForceMode2D.Impulse);
            spacesPress = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Score Left"))
        {
            giveScoreLeft++;
            pongRenderer.color = new Color(0.411988f, 0.3949359f, 0.6698113f);
            pongRB.velocity = new Vector2(0, 0f);
            transform.position = new Vector3(-5f, 0f, 0f);
            spacesPress = false;
            score = true;
            scoreLeft = true;
            scoreRight = false;
        }

        if (collision.gameObject.CompareTag("Score Right"))
        {
            giveScoreRight++;
            pongRenderer.color = new Color(0.7264151f, 0.3871929f, 0.3871929f);
            pongRB.velocity = new Vector2(0, 0f);
            transform.position = new Vector3(5f, 0f, 0f);
            spacesPress = false;
            score = true;
            scoreRight = true;
            scoreLeft = false;
        }

        if (collision.gameObject.CompareTag("Player 1"))
        {
            addSpeed++;
            pongRenderer.color = new Color(0.411988f, 0.3949359f, 0.6698113f);
        }
        if (collision.gameObject.CompareTag("Player 2"))
        {
            addSpeed++;
            pongRenderer.color = new Color(0.7264151f, 0.3871929f, 0.3871929f);
        }
    }
    
        

    }

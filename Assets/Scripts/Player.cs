using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D player;
    public float move;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //player Controllers
        if (CompareTag("Player 1"))
        {
            if (Input.GetKey(KeyCode.W))
            {
                player.AddForce(new Vector2(0, move), ForceMode2D.Force);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                player.AddForce(new Vector2(0, -move), ForceMode2D.Force);
            }
        }
        if (CompareTag("Player 2"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                player.AddForce(new Vector2(0, move), ForceMode2D.Force);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                player.AddForce(new Vector2(0, -move), ForceMode2D.Force);
            }
        }


    }


}

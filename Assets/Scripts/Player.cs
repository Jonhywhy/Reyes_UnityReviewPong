using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Transform pong ;

    private Vector2 aI;

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
        if (CompareTag("Player 2") && SceneManager.GetActiveScene().name == "Game")
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

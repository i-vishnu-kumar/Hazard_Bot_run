using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public PlayerMovement player;

    private bool jump = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //player.isJumping = jump;
        //GetComponent<AudioSource>().Play();
        if (other.gameObject.tag == "Player")
        {
            player.isJumping = jump;
            GetComponent<AudioSource>().Play();
        }
    }
}

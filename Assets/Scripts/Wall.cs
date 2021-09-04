using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public PlayerMovement player;

    public float moveTo;
    private void OnTriggerStay2D(Collider2D other)
    {
        player.horizontalMove = moveTo;
    }
}

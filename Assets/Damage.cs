using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    /*void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 5);
    }
    */
     private void OnCollisonEnter2D(Collision2D other)
     {
        Destroy(gameObject);
         /*if (collision.gameObject.tag == "Enemy")
         {
             Destroy(gameObject);
         }*/
     }
    

}


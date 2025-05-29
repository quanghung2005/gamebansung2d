using UnityEngine;

public class basicenemy :Enemy
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.takedame();
   
        }
    }
}

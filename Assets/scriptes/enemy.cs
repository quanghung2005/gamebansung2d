using UnityEngine;
public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected  float speed = 1f;
    protected player player;
    protected virtual void Start()
    {
        player = FindAnyObjectByType<player>();

    }
    protected virtual void Update()
    {
        
        {
            movetoplayer();
           
        }
    }
    protected void movetoplayer()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            flipenemy();

        }
    }
    protected void flipenemy()
    {
        if (player != null)
        {
            transform.localScale = new Vector3(player.transform.position.x < transform.position.x ? -1 : 1, 1, 1);
        }
    }
    public virtual void takedame()
    {
        die();
    }
    protected virtual void die()
    {
        Destroy(gameObject);
    }

}   
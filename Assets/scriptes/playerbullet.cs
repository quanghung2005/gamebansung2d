 using UnityEngine;

public class playerbullet : MonoBehaviour
{
    [SerializeField] private float speed = 25f;
    [SerializeField] private float timedestroy = 0.5f;

    void Start()
    {
        Destroy(gameObject, timedestroy);
    }

    void Update()
    {
        movebullet();
    }
    void movebullet()
    {
      transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.takedame();
            }
            Destroy(gameObject);
        }
        
     }        
}

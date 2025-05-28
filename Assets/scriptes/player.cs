using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveplayer();
    }
    void moveplayer()
    {
        Vector2 playerinput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.linearVelocity = playerinput.normalized * speed;
        if (playerinput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (playerinput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (playerinput != Vector2.zero)
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            animator.SetBool("isRun", false);
        }



    }
}
// abc
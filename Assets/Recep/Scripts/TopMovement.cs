using UnityEngine;

public class TopMovement : MonoBehaviour
{
    public float jumpForce = 10f; 
    public float moveSpeed = 5f;
    private Rigidbody2D rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       // float moveInput = Input.GetAxis("Horizontal");
       // rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        //if (transform.position.y < -5f)
        //{
        //    GameManager.instance.GameOver();
        //}
    }
    public void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Jump();
            GameManager.instance.AddScore(); 
        }
    }
}

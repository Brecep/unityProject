using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    public Vector2 baslangicHizi = new Vector2(2f, 2f);
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = baslangicHizi;  // linearVelocity yerine velocity kullanıyoruz
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Raket")
        {
            float fark = transform.position.x - collision.transform.position.x;
            Vector2 yeniYon = new Vector2(fark, 1).normalized;

            float hizArtisKatsayisi = 1.2f;
            rb.velocity = yeniYon * rb.velocity.magnitude * hizArtisKatsayisi;

            // Minimum hız kontrolü
            float minimumHiz = 5f; // Topun sahip olabileceği minimum hız
            if (rb.velocity.magnitude < minimumHiz)
            {
                rb.velocity = rb.velocity.normalized * minimumHiz;
            }
        }
        else
        {
            rb.velocity = Vector2.Reflect(rb.velocity, collision.contacts[0].normal);
        }
    }
}
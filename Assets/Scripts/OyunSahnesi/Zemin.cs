using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float ZýplamaKuvveti;
    public bool zemineTemasEdildi;
    float rastgeleDeger;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 zýplamaVelocity = rb.velocity;
                zýplamaVelocity.y = ZýplamaKuvveti;
                rb.velocity = zýplamaVelocity;

                if (zemineTemasEdildi == false)
                {
                    rastgeleDeger = Random.Range(1, 6);
                    Yonetici.skorSayisi+=rastgeleDeger;
                    zemineTemasEdildi = true;
                }
                anim.SetBool("TemasEdildi", true);
                Destroy(gameObject, 1f);
                
            }
        }

        
    }
}

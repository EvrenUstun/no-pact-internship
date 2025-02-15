using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D bulletBody;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        bulletBody = GetComponent<Rigidbody2D>();

        bulletBody.AddForce(new Vector2(bulletSpeed, 0), ForceMode2D.Impulse);

        Invoke("SelfDestroy", 10);
    }

    void SelfDestroy()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}

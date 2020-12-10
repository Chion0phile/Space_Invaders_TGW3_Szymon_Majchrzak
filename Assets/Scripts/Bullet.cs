using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed;
    void FixedUpdate()
    {
        transform.Translate(0, BulletSpeed * 1, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            Destroy(gameObject);
    }
}

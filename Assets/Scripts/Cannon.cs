using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameManager GameManager;
    public Transform Barrel;
    public GameObject Bullet;
    public float Cooldown;
    private float Ready;
    void Update()
    {
        if (Time.time > Ready)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                Ready = Time.time + Cooldown;
            }
        }
    }
    void Shoot()
    {
        Instantiate(Bullet, Barrel.position, Barrel.rotation);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            GameManager.EndGame = true;
        }
    }
}

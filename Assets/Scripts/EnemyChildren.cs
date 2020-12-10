﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChildren : MonoBehaviour
{
    public GameManager GameManager;
    public Transform EnemyBarrel;
    public GameObject EnemyBullet;
    public float Cooldown;
    private void FixedUpdate()
    {
        if (Random.value > Cooldown)
        {
            Instantiate(EnemyBullet, EnemyBarrel.position, EnemyBarrel.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        if(collision.tag == "Shield")
        {
            GameManager.EndGame = true;
        }
    }
}

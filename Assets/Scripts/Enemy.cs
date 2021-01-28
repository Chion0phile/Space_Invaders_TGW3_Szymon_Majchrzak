using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager GameManager;
    private float Speed;
    private int Direction = 1;
    public GameObject RightCheck;
    public GameObject LeftCheck;
    private bool Down = false;
    public float DownMove;
    private void Start()
    {
        Speed = PlayerPrefs.GetFloat("EnemySpeed");
    }
    void FixedUpdate()
    {
        //Speed = PlayerPrefs.GetFloat("EnemySpeed");
        if (RightCheck.transform.position.x > 4)
        {
            Direction = -1;
            Down = true;
        }

        if (LeftCheck.transform.position.x < -4)
        {
            Direction = 1;
            Down = true;
        }

        if (Down == true)
        {
            transform.Translate(0, -DownMove, 0);
            Down = false;
        }

        transform.Translate(Speed * Direction, 0, 0);

        if (transform.childCount < 2)
        {
            GameManager.WinGame = true;
        }
    }
}

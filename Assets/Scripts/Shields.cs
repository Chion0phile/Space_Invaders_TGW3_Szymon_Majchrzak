using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{
    public int HitPoints;
    public Sprite Shield1;
    public Sprite Shield2;
    public Sprite Shield3;
    private void FixedUpdate()
    {
        if(HitPoints == 0)
        {
            gameObject.SetActive(false);
        }
        if(HitPoints == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Shield1;
        }
        if (HitPoints == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Shield2;
        }
        if (HitPoints == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Shield3;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            HitPoints = HitPoints- 2;
        }
    }

}

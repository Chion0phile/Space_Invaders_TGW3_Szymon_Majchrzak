using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Speed * horizontal, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4, 4), transform.position.y, transform.position.z);
    }
}

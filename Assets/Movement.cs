using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //void Update()
    //{
    //    float horizontal = Input.GetAxis("Horizontal");
    //    transform.Translate(Speed * horizontal, 0, 0);
    //}

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Speed * horizontal, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4f, 4f), transform.position.y, transform.position.z);
    }
}

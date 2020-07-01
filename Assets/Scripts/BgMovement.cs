using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMovement : MonoBehaviour
{
    public float speed;
    float leftEnd = 17;
    float rightEnd = -15.9f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < rightEnd)
        {
            transform.position = new Vector2(leftEnd, transform.position.y);
        }
    }
}

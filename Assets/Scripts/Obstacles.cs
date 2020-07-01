using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField]
    Animator playerAnimator;

    [SerializeField]
    float speed;

    [SerializeField]
    AudioSource audioSource;
   

    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            audioSource.Play();
            Destroy(col.gameObject);
            GameConroler.instance.BombExploded();
        }
    }
}

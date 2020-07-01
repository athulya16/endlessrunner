using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Animator playerAnimator;

    Vector2 playerPos;
    bool isJumping = false;

    private void Awake()
    {
        playerAnimator.SetInteger("speed", 1);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isJumping)
        {
            playerAnimator.SetBool("isJumping", true);
            playerPos = new Vector2(transform.position.x , transform.position.y + 2);
            this.transform.position = playerPos;
            isJumping = true;
        }
    }

    void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if(isJumping)
        {
            if (collisionInfo.gameObject.name == "Game_play")
            {
                isJumping = false;
                playerAnimator.SetInteger("speed", 1);
                playerAnimator.SetBool("isJumping",false);
            }
        }
    }
}

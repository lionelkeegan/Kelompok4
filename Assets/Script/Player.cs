using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animator;
    [SerializeField, Range(0,20)] float speed;



    void Update()
    {
        Vector2 movDirection = Vector2.zero;
        if(Input.GetKey(KeyCode.A))
        {
            movDirection += new Vector2(-1,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            movDirection += new Vector2(1,0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            movDirection += new Vector2(0,1);
        }
        if(Input.GetKey(KeyCode.S))
        {
            movDirection += new Vector2(0,-1);
        }

        this.transform.Translate(movDirection*Time.deltaTime*speed);

        if(movDirection.x>0)
        {
            spriteRenderer.flipX =false;
        }
        else if(movDirection.x <0)
        {
            spriteRenderer.flipX = true;
        }

        animator.SetBool("IsMoving", movDirection != Vector2.zero);
    }
}

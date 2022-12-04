using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0,20)] float speed = 5;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    GameObject panelPause;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        panelPause = GameObject.Find("Canvas");
    }

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

        this.transform.Translate(movDirection * Time.deltaTime * speed);

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
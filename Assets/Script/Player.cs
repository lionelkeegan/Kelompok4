using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Animator animator;
    [SerializeField, Range(0,20)] float speed;
    public HealthBar healthBar;
    public float Health;
    public float MaxHealth;

    public int level;
    // public TMP_Text namePlayer;


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

    public void ChangeHealth(float amount)
    {
        Health += amount;
        Health = Mathf.Clamp(Health,0,100);
        //healthbar
        healthBar.UpdateHealthBar(Health/MaxHealth);
    }



    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        Health = data.Health;
        level = data.level;
        //namePlayer = data.namePlayer;

        Vector2 position;
        position.x = data.position[0];
        position.y = data.position[1];
        transform.position = position;
    }

}

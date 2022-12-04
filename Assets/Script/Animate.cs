using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animate : MonoBehaviour
{
    [SerializeField] Transform EnemyAtkPos;
    [SerializeField] Transform EnemyDmgPos;
    [SerializeField] Transform PosEnemy;
    [SerializeField] Transform HeroAtkPos;
    [SerializeField] Transform HeroDmgPos;
    [SerializeField] GameObject Enemy;
    GameObject player;
    Transform PosHero;
    public float HealthHero = 100;
    public float MaxHealthHero = 100;
    public float HealthEnemy = 100;
    public float MaxHealthEnemy = 100;
    public HealthBar healthBarEnemy;
    HealthBar healthBarHero;
    GameObject healthPoinHero;
    Animator animateEnemy;
    Animator animateHero;
    private Tweener animationTweener;
    
    private void Awake(){
        player = GameObject.FindGameObjectWithTag("Player");
        healthPoinHero = GameObject.FindGameObjectWithTag("HealthBar");
        healthBarHero = healthPoinHero.GetComponent<HealthBar>();
        PosHero = player.transform; 
        animateEnemy = Enemy.GetComponent<Animator>();
        animateHero = player.GetComponent<Animator>();
    }

    public void HeroAttack(){
        animateHero.Play("PlayerAtk");
    }

    public void HeroDamage(){
        animateHero.Play("Dead");
    }

    public void EnemyAttack(){
        animateEnemy.Play("Attack");
    }

    public void EnemyDamage(){
        animateEnemy.Play("Dead");
    }

    public void ChangeHealthEnemy(float amount)
    {
        HealthEnemy += amount;
        HealthEnemy = Mathf.Clamp(HealthEnemy, 0, 100);
        healthBarEnemy.UpdateHealthBar(HealthEnemy/MaxHealthEnemy);
    }

    public void ChangeHealthHero(float amount)
    {
        HealthHero += amount;
        HealthHero = Mathf.Clamp(HealthHero, 0, 100);
        healthBarHero.UpdateHealthBar(HealthHero/MaxHealthHero);
    }
}
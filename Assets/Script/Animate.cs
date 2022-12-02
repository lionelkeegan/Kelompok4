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
        animationTweener = PosHero
            .DOMove(HeroAtkPos.position, 0.5f)
            .SetLoops(2, LoopType.Yoyo)
            .SetDelay(0.2f);
        animateHero.SetInteger("Animate", 1);
    }

    public void HeroDamage(){
        animationTweener = PosHero
            .DOMove(HeroDmgPos.position, 0.5f)
            .SetLoops(2, LoopType.Yoyo)
            .SetDelay(0.2f);
        animateHero.SetInteger("Animate", 0);
    }

    public void EnemyAttack(){
        animationTweener = PosEnemy
            .DOMove(EnemyAtkPos.position, 0.5f)
            .SetLoops(2, LoopType.Yoyo)
            .SetDelay(0.2f);
    }

    public void EnemyDamage(){
        animationTweener = PosEnemy
            .DOMove(EnemyDmgPos.position, 0.5f)
            .SetLoops(2, LoopType.Yoyo)
            .SetDelay(0.2f);
        animateEnemy.SetInteger("Animate", 1);
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
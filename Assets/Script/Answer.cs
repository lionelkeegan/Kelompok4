using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    // public Player player;
    // public Player playerEnemy;
    public GameObject DialogPanel;
    public Animate animateHero;
    public Animate animateEnemy;

    private void Start() {
        // DialogPanel.SetActive(false);
    }

    public void Answers(bool answer)
    {
        if(answer)
        {
            animateHero.HeroAttack();
            animateEnemy.EnemyDamage();
            animateEnemy.ChangeHealthEnemy(-100);
            animateHero.ChangeHealthHero(5);
            StartCoroutine(MovePanel());
        }

        else
        {
            animateEnemy.EnemyAttack();
            animateHero.HeroDamage();
            animateHero.ChangeHealthHero(-35);
            animateEnemy.ChangeHealthEnemy(5);
        }

        // DialogPanel.SetActive(true);
        // var winner = GetWinner();
    }
    
    IEnumerator MovePanel()
    {
        yield return new WaitForSeconds(2);
        DialogPanel.SetActive(true);
    }

    private Animate GetWinner()
    {
        if(animateHero.HealthHero == 0)
        {
            return animateEnemy;
        }
        else if(animateEnemy.HealthEnemy == 0)
        {
            return animateHero;
        }
        else
        {
            return null;
        }
    }
}
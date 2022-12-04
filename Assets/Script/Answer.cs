using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public Player player;
    public Player playerEnemy;
    public GameObject DialogPanel;
    public GameObject win;
    public GameObject lose;

    bool isClickabble = true;

    private void Start()
    {
        //DialogPanel.SetActive(false);
    }
    public void Answers(bool answer)
    {
        if (answer)
        {
            player.ChangeHealth(5);
            playerEnemy.ChangeHealth(-100);
            DialogPanel.SetActive(true);
        }
        else
        {
            player.ChangeHealth(-35);
            playerEnemy.ChangeHealth(5);
        }

        //StartCoroutine(MovePanel());
        //DialogPanel.SetActive(true);
        var winner = GetWinner();
    }

    //IEnumerator MovePanel()
    //{
    //yield return new WaitForSeconds(1);
    //}

    private Player GetWinner()
    {
        if (player.Health == 0)
        {
            lose.SetActive(true);
            return playerEnemy;
        }
        else if (playerEnemy.Health == 0)
        {
            win.SetActive(true);
            return player;
        }
        else
        {
            return null;
        }
    }
    public void SetClickabble(bool value)
    {
        isClickabble = value;
    }
}

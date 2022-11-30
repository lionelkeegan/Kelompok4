using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    [SerializeField] private Sprite openedSprite;
    [SerializeField] private Sprite closedSprite;

    [SerializeField] private CanvasGroup canvasGroup;

    private List<Item> items = new List<Item>();
    
    bool isOpen;
    public void Act(Interactor interactor)
    {
        isOpen = !isOpen;
        spriteRenderer.sprite = isOpen? openedSprite : closedSprite;

        if (isOpen)
        {
            isOpen = true;
            canvasGroup.alpha = 1;
            canvasGroup.blocksRaycasts = true;
        }
        else
        {
            isOpen = false;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.alpha = 0;
        }
    }

    public void Focused(Interactor interactor)
    {
        spriteRenderer.DOColor(Color.grey, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }

    public void UnFocused(Interactor interactor)
    {
        spriteRenderer.DOKill();
        spriteRenderer.color = Color.white;
    }

    
}

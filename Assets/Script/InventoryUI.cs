using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] GameObject slotPrefab;
    [SerializeField] int numOfSlots = 5;

    List<RectTransform> slots = new List<RectTransform>();

    private void Start()
    {
        BuildSlots();
        PutItems();
        inventory.OnMemberChanged += PutItems;
    }

    private void BuildSlots()
    {
        Transform[] children = transform.GetComponentsInChildren<Transform>();
        foreach (var trans in children)
        {
            if (trans == this.transform)
                continue;
            Destroy(trans.gameObject);
        }

        slots.Clear();
        for (int i = 0; i < numOfSlots; i++)
        {
           var slot = Instantiate(original: slotPrefab, parent: this.transform);
           slots.Add(slot.GetComponent<RectTransform>());
        }
    }

    private void PutItems()
    {
        var emptySlots = numOfSlots;
        foreach (var item in inventory.Items)
        {
            if(emptySlots != 0)
            {
                item.gameObject.SetActive(true);
                item.Image.transform.SetParent(slots[numOfSlots - emptySlots]);
                item.Image.transform.localPosition = Vector3.zero;
                emptySlots -= 1;
            }
            else
            {
                item.gameObject.SetActive(false);
            }
        }
    }
}

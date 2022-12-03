using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour {
    // Start is called before the first frame update
    [SerializeField] GameObject slotPrefab;
    [SerializeField] int numOfSlots = 5;

    List<RectTransform> slots = new List<RectTransform>();

    private void Start()
    {
        BuildSlots();
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

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemButton : MonoBehaviour
{

    private TextMeshProUGUI buttonText;
    private string[] itemTypes = new string[] { "Armor", "Weapon", "Spell" };
    public int typeIndex;

    // Start is called before the first frame update
    void Awake()
    {
        typeIndex = Random.Range(0, 3);
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        buttonText.SetText(itemTypes[typeIndex]);
    }
}

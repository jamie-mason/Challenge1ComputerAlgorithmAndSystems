using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Loadout : MonoBehaviour
{
    DetectInput input;
    private TextMeshProUGUI MenuText;
    [SerializeField] private GameObject FirstSolo;

    FirstSelect firstSelect;
    private void Awake()
    {
        MenuText = GameObject.FindGameObjectWithTag("MenuName").GetComponent<TextMeshProUGUI>();
        input = GameObject.Find("MenuManager").GetComponent<DetectInput>();
        firstSelect = GameObject.Find("MenuManager").GetComponent<FirstSelect>();

    }
    public void OnClick_Back()
    {
        MenuText.text = "Solo Menu";
        MenuManager.OpenMenu(Menu.SOLO_MATCH_MENU, gameObject);
        firstSelect.setSelected(FirstSolo);

    }
    private void Update()
    {
        if (input.Escape())
        {
            OnClick_Back();
        }

    }
}

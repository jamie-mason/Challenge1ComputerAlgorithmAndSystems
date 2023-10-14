using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SoloMenu : MonoBehaviour
{
    [SerializeField] private GameObject FirstLoadout, FirstBarrack;
    FirstSelect firstSelect;
    private TextMeshProUGUI MenuText;
    private void Awake()
    {
        MenuText = GameObject.FindGameObjectWithTag("MenuName").GetComponent<TextMeshProUGUI>();
        firstSelect = GameObject.Find("MenuManager").GetComponent<FirstSelect>();

    }
    public void OnClick_Loadout()
    {
        MenuText.text = "Loadout";
        MenuManager.OpenMenu(Menu.LOADOUT, gameObject);
        firstSelect.setSelected(FirstLoadout);
    }
    public void OnClick_Barracks()
    {
        MenuText.text = "Barracks";
        MenuManager.OpenMenu(Menu.BARRACKS, gameObject);
        firstSelect.setSelected(FirstBarrack);
    }
}

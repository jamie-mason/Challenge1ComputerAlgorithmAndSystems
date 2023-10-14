using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(Button))]
public class MenuTextChange : MonoBehaviour
{
    private Button button;
    [SerializeField] private TextMeshProUGUI MenuText;
    private TextMeshProUGUI ButtonText;
 
    private void Start()
    {
        GameObject x = GameObject.FindWithTag("MenuName");
        ButtonText = GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponent<Button>();

        if(MenuText == null)
        {
            if(x != null)
            {
                MenuText = x.GetComponent<TextMeshProUGUI>();
            }

        }
        button.onClick.AddListener(ChangeMenu);
    }
    private void ChangeMenu()
    {
        //FadeToBlack
        MenuText.text = ButtonText.text;
    }
    private void Update()
    {
        
    }
}

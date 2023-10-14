using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(Outline))]
public class ColourChangeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Outline outline;
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI text;
    private Color32 textCol;
    private Color32 outlineColor;
    private void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        button = GetComponent<Button>();
        outline = GetComponent<Outline>();
        textCol = text.color;
        outlineColor = outline.effectColor;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = Color.white; 
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = textCol;
    }
    

    private void Update()
    {

        if (button != null)
        {
        }

    }
}

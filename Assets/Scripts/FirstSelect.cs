using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FirstSelect : MonoBehaviour
{
    EventSystem eventSystem;
    void Start()
    {
        eventSystem = GameObject.Find("EventSystem").GetComponent<EventSystem>();
    }
    public void setSelected(GameObject selected)
    {
        eventSystem.SetSelectedGameObject(selected);
    }
    public EventSystem GetEvent()
    {
        return eventSystem;
    }
    
}

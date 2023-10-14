using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MenuManager
{
    public static bool IsInitialised { get; private set; }
    public static GameObject SoloMenu, Barracks, Loadout;
    public static void Init()
    {
        GameObject Menus = GameObject.Find("Menus");
        SoloMenu = Menus.transform.Find("SoloMenu").gameObject;
        Barracks = Menus.transform.Find("BarracksMenu").gameObject;
        Loadout = Menus.transform.Find("LoadoutMenu").gameObject;

        IsInitialised = true;
    }
    public static void OpenMenu(Menu menu, GameObject callingMenu)
    {
        if (!IsInitialised)
        {
            Init();
        }
        switch (menu)
        {
            case Menu.SOLO_MATCH_MENU:
                SoloMenu.SetActive(true);
                break;
            case Menu.BARRACKS:
                Barracks.SetActive(true);
                break;
            case Menu.LOADOUT:
                Loadout.SetActive(true);
                break;
        }
        callingMenu.SetActive(false);
    }

}

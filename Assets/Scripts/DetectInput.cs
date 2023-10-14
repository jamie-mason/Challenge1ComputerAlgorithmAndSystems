using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DetectInput: MonoBehaviour
{
    public bool Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            return true;
        else 
            return false;
    }

}

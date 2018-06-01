using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameDebug : MonoBehaviour
{
    public bool Debug;

    private void Update()
    {
        if (Debug == true)
        {
            Time.timeScale = 0.5F;
        }
    }
}

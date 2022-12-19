using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool itemSelect = false;

    void Start()
    {
        if(!itemSelect)
        {
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        
    }
}

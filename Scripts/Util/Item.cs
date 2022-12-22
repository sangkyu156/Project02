using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item : MonoBehaviour
{
    public GameObject buyButton;
    public static Action itemAction;

    private void Awake()
    {
        itemAction = () => { SetButtonLayer(); };
    }
    void Start()
    {
        SetButtonLayer();
    }

    void SetButtonLayer()
    {
        buyButton.transform.SetAsLastSibling();
    }
}

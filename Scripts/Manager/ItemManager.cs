using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    GameObject[] items;

    private void Awake()
    {
        items = new GameObject[4];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = this.transform.GetChild(i).gameObject;
        }
    }

    void Start()
    {
        GameObject prefeb;
        GameObject skill;
        for (int i = 0; i < items.Length; i++)
        {
            prefeb = Resources.Load<GameObject>($"Skills/Fire_{i+1}");//������ ã��
            skill = Instantiate(prefeb);//������ ����
            skill.transform.SetParent(items[i].transform, false);//�θ� ����
        }
    }

    void Update()
    {
        
    }
}

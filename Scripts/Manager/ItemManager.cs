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
            prefeb = Resources.Load<GameObject>($"Skills/Fire_{i+1}");//프리펩 찾음
            skill = Instantiate(prefeb);//프리펩 생성
            skill.transform.SetParent(items[i].transform, false);//부모 지정
        }
    }

    void Update()
    {
        
    }

    void SetItem()
    {
        WRandom.WeightedRandomPicker<string> randomPicker;
        //제네릭 클래스 좀더 공부하고 가중치랜덤으로 확률 바꿔가면서 시작할때 상점에 스킬 배치해보기
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlerHand : MonoBehaviour
{
    List<Card> List = new List<Card>();

    public void Add(Card card)
    {
        List.Add(card);
        card.transform.SetParent(transform);
    }

    public void Remove(Card card)
    {
        List.Remove(card);
    }

    public void ResetPosition()
    {
        for (int i = 0; i < List.Count; i++)

        {
            float posX = (i - List.Count/2) * 100f;
            List[i].transform.localPosition = new Vector3(posX, 0);
        }

    }
}

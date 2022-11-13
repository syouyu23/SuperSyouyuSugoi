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

    //ŽèŽD‚ð®“Ú‚·‚é


    public void ResetPosition()
    {
        //Sort:Number‚Ì¬‚³‚¢‡‚É‚È‚ç‚×‚é
        List.Sort((card0, card1) => card0.Base.Number - card1.Base.Number);
        for (int i = 0; i < List.Count; i++)

        {
            float posX = (i - List.Count/2) * 100f;
            List[i].transform.localPosition = new Vector3(posX, 0);
        }

    }
    public Card RandomRemove()
    {
        int r = Random.Range(0, List.Count);
        Card card = List[r];
        Remove(card);
        return card;
    }
}

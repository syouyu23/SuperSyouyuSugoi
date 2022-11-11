using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardPrefab;
    [SerializeField] CardBase[] cardBases;

    //カードの生成
    public Card Spawn(int number)
    {
    
        Card card= Instantiate(cardPrefab);
        card.Set(cardBases[number]);
        return card;
    }


}

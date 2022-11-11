using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] CardGenerator cardGenerator;
    //カードの生成

    private void Start()
    {
        Setup();
    }
    void Setup()
    {
        SendCardsTo(player);
        SendCardsTo(enemy);

    }
    void SendCardsTo(Battler battler)
    {
        for (int i = 0; i < 8; i++)
        {
            Card card = cardGenerator.Spawn(i);
            //battler.Hand.Add(card);
            battler.SetCardToHand(card);
            battler.Hand.ResetPosition();
            Debug.Log("テスト");
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] CardGenerator cardGenerator;
    [SerializeField] GameObject submitButton;
    //カードの生成

    private void Start()
    {
        Setup();
    }
    void Setup()
    {
        player.OnSubmitAction = SubmittedAction;
        enemy.OnSubmitAction = SubmittedAction;
        SendCardsTo(player);
        SendCardsTo(enemy);

    }

    void SubmittedAction()
    {
        if(player.isSubmitted && enemy.isSubmitted)
        {
            submitButton.SetActive(false);
            //Cardの勝利判定
        }

        else if (player.isSubmitted)
        {
            submitButton.SetActive(false);//playerが提出したら
            //Enemyからカードを出す
            enemy.RandomSubmit();

        }
        else if (enemy.isSubmitted)
        {
            //playerの提出を待つ
        }
    }
    void SendCardsTo(Battler battler)
    {
        for (int i = 0; i < 8; i++)
        {
            Card card = cardGenerator.Spawn(i);
            //battler.Hand.Add(card);
            battler.SetCardToHand(card);
            battler.Hand.ResetPosition();
        }

    }
}

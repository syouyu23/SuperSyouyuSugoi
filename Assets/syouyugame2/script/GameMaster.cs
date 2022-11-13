using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [SerializeField] Battler player;
    [SerializeField] Battler enemy;
    [SerializeField] CardGenerator cardGenerator;
    [SerializeField] GameObject submitButton;
    //�J�[�h�̐���

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
            //Card�̏�������
        }

        else if (player.isSubmitted)
        {
            submitButton.SetActive(false);//player����o������
            //Enemy����J�[�h���o��
            enemy.RandomSubmit();

        }
        else if (enemy.isSubmitted)
        {
            //player�̒�o��҂�
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

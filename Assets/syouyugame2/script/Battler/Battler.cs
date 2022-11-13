using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Battler : MonoBehaviour
{
    [SerializeField] BattlerHand hand;
    [SerializeField] SubmitPosition submitPosition;
    public bool isSubmitted { get; private set; }
    public UnityAction OnSubmitAction;

    public BattlerHand Hand { get => hand;}

    public void SetCardToHand(Card card)
    {
        hand.Add(card);
        card.OnClickCard = SelectedCard;
    }

    void SelectedCard(Card card)
    {
        //���łɃZ�b�g���Ă���΁A��D�ɖ߂�
        if (isSubmitted)
        {
            return;
        }
        if (submitPosition.SubmitCard)
        {
            hand.Add(submitPosition.SubmitCard);
        }
        hand.Remove(card);
        submitPosition.Set(card);
        hand.ResetPosition();

        //Debug.Log(card.Base.Number);
    }

    public void OnSubmitButton()
    {
        if (submitPosition.SubmitCard)
        {
            isSubmitted = true;
            //GameMaster�ɒ�o
            OnSubmitAction?.Invoke();

        }
        //�J�[�h�̌���
    }

    public void RandomSubmit()
    {
        //��D���烉���_���ŃJ�[�h�𔲂����
        Card card = hand.RandomRemove();
        //��o�p��set
        submitPosition.Set(card);

        //��oGameMaster�ɒʒm����
        isSubmitted = true;

        OnSubmitAction?.Invoke();

    }

}

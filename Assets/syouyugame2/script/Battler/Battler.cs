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
        //すでにセットしていれば、手札に戻す
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
            //GameMasterに提出
            OnSubmitAction?.Invoke();

        }
        //カードの決定
    }

    public void RandomSubmit()
    {
        //手札からランダムでカードを抜き取る
        Card card = hand.RandomRemove();
        //提出用にset
        submitPosition.Set(card);

        //提出GameMasterに通知する
        isSubmitted = true;

        OnSubmitAction?.Invoke();

    }

}

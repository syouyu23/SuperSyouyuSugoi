using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitPosition : MonoBehaviour
{

    //�I�����ꂽ�J�[�h���Ǘ�����
    Card submitCard;

    public Card SubmitCard { get => submitCard;}

    //�����̎q�v�f�ɂ���E�ʒu�������̏ꏊ�ɂ���
    public void Set(Card card)
    {
        submitCard = card;
        card.transform.SetParent(transform);
        card.transform.position = transform.position;
    }

}

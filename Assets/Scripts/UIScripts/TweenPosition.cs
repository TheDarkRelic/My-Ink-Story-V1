using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TweenPosition : MonoBehaviour
{
    [SerializeField] Transform positionA, positionB;
    [SerializeField] float tweenSpeed = 1;

    public void TweenPositionToA()
    {
        var targetPosition = positionA.position;
        transform.DOMove(targetPosition, tweenSpeed);
    }

    public void TweenPositionToB()
    {
        var targetPosition = positionB.position;
        transform.DOMove(targetPosition, tweenSpeed);
    }
}

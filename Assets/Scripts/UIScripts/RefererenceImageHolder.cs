using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RefererenceImageHolder : MonoBehaviour
{
    GameObject imageHolder;

    private void Awake()
    {
        imageHolder = gameObject;
    }
    public void ScaleReferenceHolder()
    {
        imageHolder.transform.DOScale(new Vector3(2, 2, 1), 1);
        imageHolder.transform.DOMoveX(169, 1);
    }
}

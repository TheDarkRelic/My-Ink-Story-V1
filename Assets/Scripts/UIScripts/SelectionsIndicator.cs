using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionsIndicator : MonoBehaviour
{
    [SerializeField] Image needleIndicator = null, colorIndicator;

    public void SetSelectedColor(Color color)
    {
        colorIndicator.color = color;
    }

    public void SetNeedleSprite(Vector3 size)
    {
        needleIndicator.transform.localScale = size / 1.5f;
    }
}

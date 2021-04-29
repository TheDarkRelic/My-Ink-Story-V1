using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainToleranceMeter : MonoBehaviour
{
    [SerializeField] float maxPain;
    [SerializeField] float currentPain;
    [SerializeField] Image fill;

    [SerializeField] NerveMeter nerveMeter;
    [SerializeField] PainToleranceUI painUI;


    void Update()
    {
        bool playable = SceneHandler.Instance.playable;
        if (playable)
        {
            ClampMaxPain();
            var nerveLevel = nerveMeter.GetNerveLevel();
            if (nerveLevel >= nerveMeter.maxNerveLevel) { IncreaseFillAmount(); }
            GetCurrentpainLevel();
            if (currentPain >= maxPain)
            {
                painUI.ActivateClientConditionPanel();
                currentPain = 0;
                GetCurrentpainLevel();

            }
        }
        
    }

    void GetCurrentpainLevel()
    {
        var fillAmount = currentPain / maxPain;
        fill.fillAmount = fillAmount;
    }

    void IncreaseFillAmount()
    {
        currentPain += Time.deltaTime;
    }

    void ClampMaxPain()
    {
        if (currentPain >= maxPain) { currentPain = maxPain; }
    }
}

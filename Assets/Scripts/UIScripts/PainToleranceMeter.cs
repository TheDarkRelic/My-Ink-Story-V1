using UnityEngine;
using UnityEngine.UI;

public class PainToleranceMeter : MonoBehaviour
{
    [SerializeField] float maxPain = 3;
    [SerializeField] float currentPain = 0;
    [SerializeField] Image fill = null;

    [SerializeField] NerveMeter nerveMeter = null;
    [SerializeField] PainToleranceUI painUI = null;


    void Update()
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

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NerveMeter : MonoBehaviour
{
    [SerializeField] Slider nerveMeter;
    [SerializeField] Image nerveFill, painFill;
    [SerializeField] Gradient barColorGradient;
    [SerializeField] float nerveLevel, minNerveLevel = 0, maxNerveLevel, nerveDecreaseSpeed = 1, nerveIncreaseSpeed = 1;
    [SerializeField] float painLevel, minPainLevel = 0, maxPainLevel = 20;

    [SerializeField] MachineVibrate machineVibrate;


    private void Awake()
    {
        SetMaxNerveLevel();
    }

    void Update()
    {
        
        //float amount = (painLevel / 100.0f) * 180.0f / 360;
        //painFill.fillAmount = amount;
        if (Input.GetMouseButton(0))
        {
            nerveLevel += Time.deltaTime;
            if (nerveLevel > maxNerveLevel)
            {
                nerveLevel = maxNerveLevel;
            }
            
            
        }
        else
        {
            machineVibrate.shaking = false;
            nerveLevel -= Time.deltaTime * nerveDecreaseSpeed;
            if (nerveLevel <= 0) { nerveLevel = minNerveLevel; }
        }

        SetCurrentNerveLevel();
    }

    private void SetCurrentNerveLevel()
    {
        nerveMeter.value = nerveLevel;
        nerveFill.color = barColorGradient.Evaluate(nerveMeter.normalizedValue);
    }

    private void SetMaxNerveLevel()
    {
        nerveMeter.maxValue = maxNerveLevel;
        barColorGradient.Evaluate(1);
    }

}

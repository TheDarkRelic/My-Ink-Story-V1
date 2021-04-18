using UnityEngine;
using UnityEngine.UI;

public class NerveMeter : MonoBehaviour
{
    [SerializeField] Slider nerveMeter;
    [SerializeField] Image fill;
    [SerializeField] Gradient barColorGradient;
    [SerializeField] float nerveLevel, minNerveLevel = 0, maxNerveLevel, nerveDecreaseSpeed = 1, nerveIncreaseSpeed = 1;

    [SerializeField] MachineVibrate machineVibrate;

    private void SetMaxNerveLevel()
    {
        nerveMeter.maxValue = maxNerveLevel;
        barColorGradient.Evaluate(1);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            nerveLevel += Time.deltaTime;
            if (nerveLevel > maxNerveLevel) { nerveLevel = maxNerveLevel; }
            if (nerveLevel >= 2.2f)
            {
                machineVibrate.shaking = true;
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
        fill.color = barColorGradient.Evaluate(nerveMeter.normalizedValue);
    }
}

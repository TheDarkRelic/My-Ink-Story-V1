using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NerveMeter : MonoBehaviour
{
    [SerializeField] Slider nerveMeter;
    [SerializeField] Image nerveFill;
    [SerializeField] Gradient barColorGradient;
    [SerializeField] float nerveLevel, minNerveLevel = 0, nerveDecreaseSpeed = 1, nerveIncreaseSpeed = 1;
    public float maxNerveLevel;

    [SerializeField] MachineVibrate machineVibrate;


    private void Awake()
    {
        SetMaxNerveLevel();
    }

    void Update()
    {
        
        if (SceneHandler.Instance.playable && Input.GetMouseButton(0))
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

    public float GetNerveLevel()
    {
        return nerveLevel;
    }

}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.InputSystem;

public class NerveMeter : MonoBehaviour
{
    [SerializeField] Slider nerveMeter = null;
    [SerializeField] Image nerveFill = null;
    [SerializeField] Gradient barColorGradient = null;
    [SerializeField] float nerveLevel, minNerveLevel = 0, nerveDecreaseSpeed = 1;
    public float maxNerveLevel;
    PlayerActions _actions;

    private void Awake()
    {
        SetMaxNerveLevel();
        _actions = new PlayerActions();
    }

    void Update()
    {

        if (_actions.TattooControls.RunMachine.ReadValue<bool>())
        {
            nerveLevel += Time.deltaTime;
            if (nerveLevel > maxNerveLevel)
            {
                nerveLevel = maxNerveLevel;
            }
        }
        else
        {
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

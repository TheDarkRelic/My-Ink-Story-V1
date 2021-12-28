using UnityEngine;
using TMPro;

public class PainToleranceUI : MonoBehaviour
{
    [SerializeField] TMP_Text clientConditonText;
    [SerializeField] GameObject clientConditionPanel = null;

    public void ActivateClientConditionPanel()
    {
        clientConditionPanel.SetActive(true);
        Cursor.visible = true;
    }
}

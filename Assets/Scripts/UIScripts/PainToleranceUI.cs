using UnityEngine;
using TMPro;

public class PainToleranceUI : MonoBehaviour
{
    [SerializeField] TMP_Text clientConditonText;
    [SerializeField] GameObject clientConditionPanel;
    [SerializeField] Raycasting raycasting;

    public void ActivateClientConditionPanel()
    {
        SceneHandler.Instance.TogglePlayable();
        raycasting.enabled = false;
        clientConditionPanel.SetActive(true);
        Cursor.visible = true;
    }
}

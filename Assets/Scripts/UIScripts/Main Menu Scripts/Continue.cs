using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    private void OnEnable()
    {
        var button = GetComponent<Button>();
        if (PlayerPrefs.GetString("PlayerName") == "") { button.interactable = false; }
        else { button.interactable = true; }
    }
}

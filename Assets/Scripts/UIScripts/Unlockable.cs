using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour
{
    [SerializeField] GameObject lockPanel = null;
    [SerializeField] int designNumber = 0;
    [SerializeField] Button roseButton = null, diamondButton = null;
    public int designsUnlocked;

    private void Awake()
    {
        roseButton.interactable = false;
        diamondButton.interactable = false;
    }

    private void OnEnable()
    {
        designsUnlocked = PlayerPrefs.GetInt("DesignUnlocked");
        if (designsUnlocked == 1 && designNumber == 1)
        {
            lockPanel.SetActive(false);
            diamondButton.interactable = true;
        }

        if (designsUnlocked == 2)
        {
            lockPanel.SetActive(false);
            roseButton.interactable = true;
            diamondButton.interactable = true;
        }

    }

    public void UnlockPanel( int selectedDesign)
    {
        if (designNumber == selectedDesign)
        lockPanel.SetActive(false);
        PlayerPrefs.SetInt("DesignUnlocked",selectedDesign);
        Debug.Log(PlayerPrefs.GetInt("DesignUnlocked"));
        
    }
}

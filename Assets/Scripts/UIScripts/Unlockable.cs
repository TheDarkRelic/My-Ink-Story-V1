using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable : MonoBehaviour
{
    [SerializeField] GameObject lockPanel;
    [SerializeField] int designNumber;
    public int designsUnlocked;

    private void OnEnable()
    {
        designsUnlocked = PlayerPrefs.GetInt("DesignUnlocked");
        if (designsUnlocked == 1 && designNumber == 1)
        {
            lockPanel.SetActive(false); 
        }
        else if (designsUnlocked == 2)
        {
            lockPanel.SetActive(false);
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

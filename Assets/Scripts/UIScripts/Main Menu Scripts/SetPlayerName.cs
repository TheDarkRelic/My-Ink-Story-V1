using UnityEngine;

public class SetPlayerName : MonoBehaviour
{
    public void SavePlayerName(string playerName)
    {
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    public void CheckForSavedName(GameObject namePanel)
    {
        var name = PlayerPrefs.GetString("PlayerName");
        if (name == null) { namePanel.SetActive(true); }
        else { namePanel.SetActive(false); }
    }
}

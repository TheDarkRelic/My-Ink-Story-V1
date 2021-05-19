using TMPro;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject tutorialBox1 = null;
    [SerializeField] MayoTrayUI mayoTray = null;
    [SerializeField] TMP_Text playerName = null;
    string complete;
    Raycasting raycasting = null;

    private void Awake()
    {
        raycasting = FindObjectOfType<Raycasting>();
    }

    private void OnEnable()
    {
        playerName.text = $"Hello {PlayerPrefs.GetString("PlayerName")},";
        complete = PlayerPrefs.GetString("Complete");
        if (complete == "Yes") { CloseTutorialBox(tutorialBox1); }
        else { OpenTutorialBox(tutorialBox1); }
    }

    public void CloseTutorialBox(GameObject boxToClose)
    {
        boxToClose.SetActive(false);
    }

    public void OpenTutorialBox(GameObject boxToOpen)
    {
        if (complete != "Yes") { boxToOpen.SetActive(true); }
        else { mayoTray.PullOutTray(); }
    }

    public void FinishTutorialBox(GameObject boxToClose)
    {
        PlayerPrefs.SetString("Complete", "Yes");
        boxToClose.SetActive(false);
    }

    public void ClietPainWarning(GameObject tutorialBox4)
    {
        string hasWarned = PlayerPrefs.GetString("HasWarned");
        if (hasWarned != "Yes")
        {
            ToggleCursor(true);
            ToggleRaycast(false);
            PlayerPrefs.SetString("HasWarned", "Yes");
            tutorialBox4.SetActive(true);
        }
    }

    public void ToggleRaycast(bool isRaycasting)
    {
        raycasting.enabled = isRaycasting;
    }

    public void ToggleCursor(bool isVisible)
    {
        Cursor.visible = isVisible;
    }
}

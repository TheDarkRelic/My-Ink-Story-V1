using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject tutorialBox1 = null;
    [SerializeField] MayoTrayUI mayoTray = null;
    string complete;

    private void OnEnable()
    {
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

    public void ClietPainWarning(GameObject tutorialBox5)
    {
        string hasWarned = PlayerPrefs.GetString("HasWarned");
        if (hasWarned != "Yes")
        {
            PlayerPrefs.SetString("HasWarned", "Yes");
            tutorialBox5.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject tutorialBox1;
    static bool tutorialComplete;

    private void Awake()
    {
        if (!tutorialComplete) { OpenTutorialBox(tutorialBox1); }
        else { CloseTutorialBox(tutorialBox1); }
    }

    public void CloseTutorialBox(GameObject boxToClose)
    {
        tutorialComplete = true;
        boxToClose.SetActive(false);
    }

    public void OpenTutorialBox(GameObject boxToOpen)
    {
        boxToOpen.SetActive(true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{
    public enum Difficulty { Apprentice, Professional, Master};

    public Difficulty difficulty;
    string difficultySetting;
    [SerializeField] TMP_Dropdown dropdown = null;

    private void OnEnable()
    {
        var currentDifficuly = PlayerPrefs.GetInt("Difficulty");
        PopulateDifficultyOptions();
        SelectDifficulty(currentDifficuly);
        SceneHandler.Instance.SetDifficultyString(difficultySetting);
        SetDifficultyOption(currentDifficuly);
    }

    public void SelectDifficulty(int difficultyIndex)
    {
        Difficulty difficultyOption = (Difficulty)difficultyIndex;
        difficulty = difficultyOption;
        PlayerPrefs.SetInt("Difficulty", difficultyIndex);
        SetDifficultyString();
        SceneHandler.Instance.SetDifficultyString(difficultySetting);
    }

    void PopulateDifficultyOptions()
    {
        dropdown.ClearOptions();
        string[] enumOptions = Enum.GetNames(typeof(Difficulty));
        List<string> options = new List<string>(enumOptions);
        dropdown.AddOptions(options);
    }

    public void SetDifficultyString()
    {
        
        switch (difficulty)
        {
            case DifficultySelector.Difficulty.Apprentice:
                difficultySetting = "Apprentice";
                break;
            case DifficultySelector.Difficulty.Professional:
                difficultySetting = "Professional";
                break;
            case DifficultySelector.Difficulty.Master:
                difficultySetting = "Master";
                break;
        }
    }

    void SetDifficultyOption(int difficultyIndex)
    {
        dropdown.value = difficultyIndex;
    }

}

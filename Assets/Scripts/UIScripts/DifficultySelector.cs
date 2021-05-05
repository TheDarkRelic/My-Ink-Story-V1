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
    [SerializeField] TMP_Dropdown dropdown = null;

    private void Start()
    {
        PopulateDifficultyOptions();
    }

    public void SelectDifficulty(int difficultyIndex)
    {
        Difficulty difficultyOption = (Difficulty)difficultyIndex;
        difficulty = difficultyOption;
        PlayerPrefs.SetInt("Difficulty", difficultyIndex);
    }

    void PopulateDifficultyOptions()
    {
        dropdown.ClearOptions();
        string[] enumOptions = Enum.GetNames(typeof(Difficulty));
        List<string> options = new List<string>(enumOptions);
        dropdown.AddOptions(options);

    }
}

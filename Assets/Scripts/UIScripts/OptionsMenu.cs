using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer = null;
    [SerializeField] Slider masterSlider = null;
    [SerializeField] Toggle toggleMute = null;
    [SerializeField] TMP_Dropdown qualityDropdown = null;
    float storedVolume;
    bool isMuted;

    private void Start()
    {
        var savedQSetting = PlayerPrefs.GetInt("QualitySetting");
        qualityDropdown.value = savedQSetting;
        SetQuality(savedQSetting);

        var savedVolume = PlayerPrefs.GetFloat("Master");
        if (savedVolume > -80) { toggleMute.isOn = false; }
        else { toggleMute.isOn = true; }

        this.isMuted = false;
        masterSlider.value = savedVolume;
    }

    private void Update()
    {
        if (isMuted) { masterSlider.value = -80; }
    }

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("master", volume);
        PlayerPrefs.SetFloat("Master", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("QualitySetting", qualityIndex);
    }

    public void ToggleMute(bool isMuted)
    {
        if (isMuted)
        {
            this.isMuted = true;
            storedVolume = masterSlider.value;
            audioMixer.SetFloat("master", -80);
            masterSlider.value = -80;
        }
        else
        {
            this.isMuted = false;
            masterSlider.value = storedVolume;
            audioMixer.SetFloat("master", masterSlider.value);
        }
    }

    public void ResetLocks()
    {
        PlayerPrefs.DeleteKey("DesignUnlocked");
        PlayerPrefs.DeleteKey("Complete");
        PlayerPrefs.DeleteKey("HasWarned");
    }
}

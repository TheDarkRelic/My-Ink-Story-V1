using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;

public class Machine : MonoBehaviour
{
    public Animator animator = null;
    [SerializeField] AudioSource audioSource = null;
    public bool playAudio;


    void PlayAudioSource()
    {
        if (playAudio) { audioSource.enabled = true; }
        else { audioSource.enabled = false; }
    }
}

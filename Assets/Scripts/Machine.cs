using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;

public class Machine : MonoBehaviour
{
    public Animator animator = null;
    [SerializeField] Raycasting raycasting = null;
    [SerializeField] float smoothing = .2f;
    [SerializeField] AudioSource audioSource = null;
    bool playAudio;

    private void Update()
    {

        if (Mouse.current.leftButton.isPressed && Physics.Raycast(raycasting.ray, out raycasting.hit, 100, raycasting.layerMask) && transform != null && SceneHandler.Instance.playable)
        {
            playAudio = true;
            animator.SetBool("Running", true);
            if (transform != null) { transform.DOMove(raycasting.hit.point, .2f); }
        }
        else
        {
            playAudio = false;
            if (transform != null)
            { transform.DOMove(raycasting.hit.point + (Vector3.up * raycasting.machineHieght) + (-Vector3.forward * 2), smoothing); }

            animator.SetBool("Running", false);
        }

        PlayAudioSource();
        
    }

    void PlayAudioSource()
    {
        if (playAudio) { audioSource.enabled = true; }
        else { audioSource.enabled = false; }
    }
}

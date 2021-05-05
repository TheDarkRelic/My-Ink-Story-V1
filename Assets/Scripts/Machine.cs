using UnityEngine;
using DG.Tweening;

public class Machine : MonoBehaviour
{
    [SerializeField] Animator animator = null;
    [SerializeField] Raycasting raycasting = null;
    [SerializeField] MachineVibrate vibrate = null;
    [SerializeField] float smoothing = .2f;
    [SerializeField] AudioSource audioSource = null;
    private bool playAudio;

    private void Update()
    {

        if (Input.GetMouseButton(0) && Physics.Raycast(raycasting.ray, out raycasting.hit, 100, raycasting.layerMask) && transform != null && SceneHandler.Instance.playable)
        {
            playAudio = true;
            animator.SetBool("Running", true);
            if (transform != null) { transform.DOMove(raycasting.hit.point, .2f); }

            if (raycasting.hit.collider != null)
            {
                if (!vibrate.vibrating) { vibrate.StartCoroutine("MachineVibrating"); }
            }
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

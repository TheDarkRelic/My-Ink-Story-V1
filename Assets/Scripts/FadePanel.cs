using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePanel : MonoBehaviour
{
    [SerializeField] Animator animator = null;

    public void PlayAnimation()
    {
        animator.Play("FadePanel_Anim");
    }

    public void LoadSceneAfterAnimation()
    {
        SceneHandler.Instance.LoadScene(1);
    }
}

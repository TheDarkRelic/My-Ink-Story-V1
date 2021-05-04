using UnityEngine;
using UnityEngine.UI;

public class UnlockDesignHandler : MonoBehaviour
{
    [SerializeField] Button roseButton, diamondButton;

    private void Awake()
    {
        roseButton.interactable = false;
        diamondButton.interactable = false;
    }

}

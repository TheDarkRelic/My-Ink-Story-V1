using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

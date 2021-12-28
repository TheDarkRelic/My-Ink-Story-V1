using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneHandler : MonoBehaviour
{
    private static SceneHandler instance;
    public string difficultySetting = "Apprentice";
    public static SceneHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SceneHandler>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(SceneHandler).Name;
                    instance = obj.AddComponent<SceneHandler>();
                }
            }
            return instance;
        }
    }

    public virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as SceneHandler;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }


    public void SetDifficultyString(string difficulty)
    {
        difficultySetting = difficulty;
    }
}

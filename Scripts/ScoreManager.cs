using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text sceneText;

    void Start()
    {
        UpdateSceneText();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void UpdateSceneText()
    {
        if (sceneText != null)
        {
            sceneText.text = "—чет: " + SceneManager.GetActiveScene().name;
        }
    }
}

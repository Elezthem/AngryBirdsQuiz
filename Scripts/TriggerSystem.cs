using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerSystem : MonoBehaviour
{
    public GameObject scorePanel;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.CompareTag("platform_trigger") && other.CompareTag("false_trigger"))
        {
            scorePanel.SetActive(true);
        }

        else if (this.CompareTag("platform_trigger") && other.CompareTag("true_trigger"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}

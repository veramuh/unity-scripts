using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded =false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void comleteLevel()
    {
        Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled=false;
    }

    public void EndGame()
    {
        if(!gameHasEnded)
        {
            gameHasEnded=true;
            Debug.Log("GAME OVER");
            Invoke("restart",restartDelay);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

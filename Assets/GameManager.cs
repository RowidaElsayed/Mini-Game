using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gamened=false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI; 
    public void EndGame()
    {
        if (gamened == false)
        {
            gamened = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}

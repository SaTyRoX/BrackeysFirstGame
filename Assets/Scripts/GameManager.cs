using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1;

    public GameObject completeLevelUI;

    public void CompleteLevel () {
        completeLevelUI.SetActive(true);
    }

    public void EndGame () {

        if (gameHasEnded == false) {

            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("restart", restartDelay);
        }
    }

    void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

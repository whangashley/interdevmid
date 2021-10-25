using UnityEngine.SceneManagement;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }





        /*
        if (sixKeys == true)
        {
            WinScreen.SetActive(true);
        }

        if (playerDead == true)
        {
            GameOverScreen.SetActive(true);
        }*/
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

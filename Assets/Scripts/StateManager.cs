using UnityEngine.SceneManagement;
using UnityEngine;

//code based off of GDTitan's youtube tutorials

public class StateManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    public static bool isGameWin;
    public GameObject gameWinScreen;

    private void Awake()
    {
        isGameOver = false;
        isGameWin = false;
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

        if (isGameWin)
        {
            gameWinScreen.SetActive(true);
        }
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

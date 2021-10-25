using UnityEngine.SceneManagement;
using UnityEngine;

//code based off of GDTitan's youtube tutorials

public class MenuEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
  
    private void Awake()
    {
        isGameOver = false;
    }
     
     void Start()
     {

     }
   
    void Update()
    {
        if (isGameOver)
        {

               gameOverScreen.SetActive(true);
        }
    }

    public void Replaylevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

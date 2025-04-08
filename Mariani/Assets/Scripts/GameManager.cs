using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 5;
  
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Level1");
        }
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Level2");
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("Level3");
        }
    }
}

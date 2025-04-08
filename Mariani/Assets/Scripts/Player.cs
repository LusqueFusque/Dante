using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            Debug.Log("pontos " + FindFirstObjectByType<GameManager>().pontos);
            Debug.Log("vidas " +  FindFirstObjectByType<GameManager>().vidas);
        }
        
        if (Keyboard.current.vKey.wasPressedThisFrame)
        {
            Debug.Log("vidas " +  FindFirstObjectByType<GameManager>().vidas--);
        }
        
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            Debug.Log("pontos " + (FindFirstObjectByType<GameManager>().pontos+=1000));
        }
    }
}
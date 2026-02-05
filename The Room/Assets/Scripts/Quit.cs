using UnityEngine;
using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{
    public InputActionReference quitAction;
    public InputActionReference breakAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool breakOut = true;
        quitAction.action.Enable();
        quitAction.action.performed += (ctx) => 
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        };
        breakAction.action.Enable();
        breakAction.action.performed += (ctx) => 
        {
            if (breakOut == true)
            {
                transform.position = new Vector3(0f, 10f,-38.45f);
                breakOut = false;
            }
            else
            {
                transform.position = new Vector3(0f, -5f,0f);
                breakOut = true;
            }
            
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

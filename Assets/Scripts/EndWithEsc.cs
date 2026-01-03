using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class EndWithEsc : MonoBehaviour
{
    void OnEsc()
    {
        Debug.Log("Exit");
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
                    Application.Quit();
#endif
    }
}

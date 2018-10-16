using UnityEngine;
using UnityEngine.SceneManagement;

public class Commands_Signup : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        SceneManager.LoadScene(1);
    }
}
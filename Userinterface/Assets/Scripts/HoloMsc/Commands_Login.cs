using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Commands_Login : MonoBehaviour {

    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        SceneManager.LoadScene(2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Commands_LoginCheck : MonoBehaviour
{

    void OnSelect()
    {
        SignIn.UserEntered();
        // If the sphere has no Rigidbody component, add one to enable physics.
        //SceneManager.LoadScene(0); //checking with 0

    }
}

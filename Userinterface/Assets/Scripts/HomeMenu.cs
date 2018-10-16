using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenu : MonoBehaviour {

    //This function transitions scenes from the Main Menu Scene to the Sign Up Scene once the User clicks on the "Sign in" Button
	public void toSignUp()
    {
        SceneManager.LoadScene(1);
    }
    public void toLoginIn()
    {
        SceneManager.LoadScene(2);
    }
}

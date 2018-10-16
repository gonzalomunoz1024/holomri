using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogOffButton : MonoBehaviour {

    public void toLogOut()
    {
        SceneManager.LoadScene(0);
    }
}

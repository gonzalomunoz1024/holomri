using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PatientSelectionButton : MonoBehaviour {

    public static string name;

    public void buttonChoice()
    {
        name = EventSystem.current.currentSelectedGameObject.transform.gameObject.GetComponentInChildren<Text>().text;
        Debug.Log(name);
        SceneManager.LoadScene(4);
    }
}

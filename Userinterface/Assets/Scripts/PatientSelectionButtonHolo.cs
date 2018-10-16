using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PatientSelectionButtonHolo : MonoBehaviour
{
    public static string name;

    void OnSelect()
    {
        //name = EventSystem.current.transform.gameObject.GetComponentInChildren<Text>().text;
            
            
        // .currentSelectedGameObject.transform.gameObject.GetComponentInChildren<Text>().text;
        //Debug.Log(name);
        SceneManager.LoadScene(5);
    }
}

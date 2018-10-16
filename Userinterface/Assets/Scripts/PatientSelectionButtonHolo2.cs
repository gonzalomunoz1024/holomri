using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Temp Script until dynamic table view is fixed
public class PatientSelectionButtonHolo2 : MonoBehaviour
{
    public static string name;

    void OnSelect()
    {
        //name = EventSystem.current.transform.gameObject.GetComponentInChildren<Text>().text;


        // .currentSelectedGameObject.transform.gameObject.GetComponentInChildren<Text>().text;
        //Debug.Log(name);
        SceneManager.LoadScene(6);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Series : MonoBehaviour {

    public Text status;

    public void Start()
    {
        status.text = PatientSelectionButton.name;

        status.text = "Welcome " + status.text;

    }
}

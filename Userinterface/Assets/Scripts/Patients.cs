using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patients : MonoBehaviour {

    public RectTransform prefab;
    public Text countText;
    public ScrollRect scrollView;
    public RectTransform content;

    public string patientOfChoice;

    string giantString;
    public string[] registerUsers;
    public string[] fnames = new string[100];
    public string[] lnames = new string[100];
    public string[] patients = new string[100];
    public string[] ssn = new string[100];
    
    IEnumerator Start()
    {
        WWW users = new WWW("http://hololidar.000webhostapp.com/readpatients.php");
        yield return users;

        giantString = users.text;

        registerUsers = giantString.Split(';');

        create("Drake", "Graham", "000000831");
        create("Michael", "Jackson", "000000983");
        create("John", "Cena", "000001234");

        /*
        for (int i = 0; i < registerUsers.Length - 1; i++)
        {
            
            //Debug.Log(SignIn.PhysicianName.ToString());


            fnames[i] = registerUsers[i].Substring(6);
            fnames[i] = fnames[i].Remove(fnames[i].IndexOf('|'));
            fnames[i] = fnames[i].Substring(0, (fnames[i].Length - 1));

            lnames[i] = registerUsers[i].Substring(registerUsers[i].IndexOf('|') + 7);
            lnames[i] = lnames[i].Remove(lnames[i].IndexOf('|'));

            patients[i] = registerUsers[i].Substring(registerUsers[i].IndexOf('|') + 7);
            patients[i] = patients[i].Substring(patients[i].IndexOf('|') + 13);
            patients[i] = patients[i].Remove(patients[i].IndexOf('|'));
            patients[i] = patients[i].Substring(0, (patients[i].Length - 1));

            ssn[i] = registerUsers[i].Substring(registerUsers[i].IndexOf('|') + 7);
            ssn[i] = ssn[i].Substring(ssn[i].IndexOf('|') + 13);
            ssn[i] = ssn[i].Substring(ssn[i].IndexOf('|') + 5);
            //emails[i] = patients[i].Remove(patients[i].IndexOf('|'));

            Debug.Log("_" + SignIn.PhysicianName.ToString() + "____" + patients[i] + "_");

            if (patients[i] == SignIn.PhysicianName.ToString()) 
            create(fnames[i], lnames[i], ssn[i]);

            //password[i] = registerUsers[i].Substring(registerUsers[i].IndexOf('|') + 10);
            //password[i] = usernames[i].Substring()
        }
        */

    }

    public void create(string fname, string lname, string ssn)
    {
        var instance = GameObject.Instantiate(prefab.gameObject) as GameObject;
        instance.transform.SetParent(content, false);

        Transform test = instance.transform.Find("Fname");
        Text score = test.gameObject.GetComponent<Text>();
        score.text = fname;

        test = instance.transform.Find("Lname");
        score = test.gameObject.GetComponent<Text>();
        score.text = lname;

        test = instance.transform.Find("ssn");
        score = test.gameObject.GetComponent<Text>();
        ssn = ssn.Substring(5);
        score.text = ssn;


         //instance.transform.Find("Button").gameObject.GetComponentInChildren<Text>().text = ssn;
         instance.transform.Find("Capsule").gameObject.GetComponentInChildren<Text>().text = ssn;


        //initalizeItem(instance);
    }

    //Now I need to generate each item from this menu
    void initalizeItem(GameObject viewGameObject)
    {
        
    }

    public void patientSelection()
    {
        
    }
}

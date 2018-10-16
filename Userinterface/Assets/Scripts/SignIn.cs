using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignIn : MonoBehaviour
{
    public Text status;
    public InputField inputUser, inputerPassword;
    public static int currentID = 0;

    string giantString;

    public static string PhysicianName = "";

    public Button submitButton;

    public string[] registerUsers;

    public string[] usernames = new string[100];
    public string[] password = new string[100];

    IEnumerator Start()
    {
        WWW users = new WWW("http://hololidar.000webhostapp.com/read.php");
        yield return users;

        giantString = users.text;

        registerUsers = giantString.Split(';');


        for (int i = 0; i < registerUsers.Length - 1; i++)
        {
            usernames[i] = registerUsers[i].Substring(9);
            usernames[i] = usernames[i].Remove(usernames[i].IndexOf('|'));
            usernames[i] = usernames[i].Substring(0, (usernames[i].Length - 1));

            password[i] = registerUsers[i].Substring(registerUsers[i].IndexOf('|') + 10);
            //password[i] = usernames[i].Substring()
        }
    }

    public static void UserEntered()
    {
        currentID = 1;
    }

    /*
    private void Update()
    {
        if (currentID == 1)
        {
            TryToLogin();
        }
    }
    */

    public static void PasswordEntered()
    {
        //inputerPassword.text = KeyboardGG.inputString;
    }

    public void TryToLogin()
    {
        currentID = -1;
        
        inputUser.text = KeyboardGG.transferUserName.text;
        inputerPassword.text = KeyboardGG_2.transferUserName.text;

        //The following lines of code are temporary placeholders until the actual database is in working order
        if (inputUser.text == "" || inputerPassword.text == "")
        {
            status.text = "Username or password field cannot be left empty";       //altered
        }
        else
        {
           if (inputUser.text != "test")
            {
                status.text = "Username not found!";
            }
           else if (inputerPassword.text != "test123")
            {
                status.text = "Incorrect Password try again";
            }
           else
            {
                status.text = "Success!";
                PhysicianName = inputUser.text;
                UnityEngine.SceneManagement.SceneManager.LoadScene(3);
            }
        }

        /*
        if (inputUser.text == "" || inputerPassword.text == "")
        {
            status.text = "Username or password cannot be left empty";       //altered
        }
        else
        {
            for (int i = 0; i < registerUsers.Length - 1; i++)
            {
                // Debug.Log("Userinput = " + "_"+ inputUser.text + "_" + " Database at position " + i + " = " + "_" + usernames[i] + "_");
                if (inputUser.text == usernames[i]) //need to fix this line of code here because the comparison is not working properly
                {
                    currentID = i;
                    Debug.Log("CurrentID is now: " + currentID);

                }
            }

            if (currentID == -1)
            {
                // status.text = "Username not found for " + inputUser.text + " " + inputerPassword.text;
                status.text = "Username not found!";
                // status.text = "Username at position 0 = " + usernames[0];
            }
            else
            {
                if (inputerPassword.text == password[currentID])
                    {
                               
                        status.text = "Success!";
                        PhysicianName = inputUser.text;
                        UnityEngine.SceneManagement.SceneManager.LoadScene(3);

                    }
                    else
                    {
                        status.text = "Incorrect Password!";
                    }
                }
            }
        */

    }


}

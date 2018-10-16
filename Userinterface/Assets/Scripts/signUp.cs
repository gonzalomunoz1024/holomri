using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class signUp : MonoBehaviour {


    public Text status;
    public InputField inputUser, inputPassword, regPassword, regEmail, regUsername;
    public InputField regFname, regLname;
    int currentID;
    bool takenUsername;

    string giantString;

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

    public void tryToRegister()
    {
        takenUsername = false;

        regUsername.text = KeyboardGG.inputString;

        //temp
        status.text = regUsername.text;

        if (regUsername.text == "" || regPassword.text == "" || regEmail.text == "")
        {
            status.text = "No empty fields allowed";
        }
        else
        {
            for (int i = 0; i < registerUsers.Length - 1; i++)
            {
                if (regUsername.text == usernames[i])
                {
                    takenUsername = true;
                }
            }

            if (takenUsername == false)
            {
                status.text = "Registeration Successful!";
                registerUser(regUsername.text, regPassword.text, regEmail.text, regFname.text, regLname.text);
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
            else
            {
                status.text = "Invalid username";
            }
        }
    }

    public void registerUser(string username, string password, string email, string fName, string lName)
    {
        WWWForm form = new WWWForm();

        form.AddField("fnamePost", fName);
        form.AddField("lnamePost", lName);
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);
        form.AddField("emailPost", email);

        WWW register = new WWW("http://hololidar.000webhostapp.com/write.php", form);


    }
}

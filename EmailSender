using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailSender : MonoBehaviour
{
    public void OnClickEvent()
    {
        string mailto = "Email Address"; 
        string subject = EscapeURL("Title"); 
        string body = EscapeURL
            ("contats"

            );
        Application.OpenURL("mailto:" + mailto + "?subject=" + subject + "&body=" + body);
    }
    private string EscapeURL(string url)
    { 
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}

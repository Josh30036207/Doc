using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class characterText : MonoBehaviour
{
    public string msg;
    public TMP_Text msgText;

    public void updateText()
    {
        msgText.SetText("" + msg);
    }
}

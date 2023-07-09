using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class fees : MonoBehaviour
{
    public float fee = 0;
    public TMP_Text feeText;

    private void Update()
    {
        feeText.SetText("£" + fee);
    }
}

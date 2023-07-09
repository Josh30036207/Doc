using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class resources : MonoBehaviour
{
    public int cash = 30;
    public int opinion = 30;
    public int divorce = 30;
   
    public TMP_Text cashText;
    public TMP_Text opinionText;
    public TMP_Text divorceText;


    private void Start()
    {
        cash = 30;
        opinion = 30;
        divorce = 30;
    }

    public void modCash(int val)
    {
        cash += val;
        maxVal();
        modText();
        Debug.Log("val = " + val + "cash = " + cash);
    }

    public void modOpinion(int val)
    {
        opinion += val;
        maxVal();
        modText();
    }

    public void modDivorce(int val)
    {
        divorce += val;
        maxVal();
        modText();
    }

    private void maxVal()
    {
        if (cash > 50) { cash = 50; }
        else if (opinion > 50) { opinion = 50; }
        else if (divorce > 50) { divorce = 50; };
    }

    private void modText()
    {
        cashText.SetText(""+cash);
        opinionText.SetText("" + opinion);
        divorceText.SetText("" + divorce);
        checklose();

    }

    private void checklose()
    {
        //check if lost
        if (cash <= 0||opinion <=0||divorce <= 0){
            Debug.Log("Lost");
            Debug.Log("Fee:" + cash + opinion + divorce);
            SceneManager.LoadScene(2);
        };
        
    }
}



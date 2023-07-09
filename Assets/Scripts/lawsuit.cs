using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lawsuit : MonoBehaviour
{
    public resources resources;
    public characterText characterText;

    public int cashA;
    public int cashB;
    public int opinionA;
    public int opinionB;
    public int divorceA;
    public int divorceB;
    public string msg;

    public int random;

    public TextAsset characterJSON;
    [System.Serializable]
    public class character
    {
        public int cashA;
        public int cashB;
        public int opinionA;
        public int opinionB;
        public int divorceA;
        public int divorceB;
        public string msg;
    }

    [System.Serializable]
    public class characterList
    {
        public character[] character;
    }

    public characterList newCharacter = new characterList();

    private void Start()
    {
        newCharacter = JsonUtility.FromJson<characterList>(characterJSON.text);
        updateCharacter();


    }

    public void updateCharacter()
    {

        random = Random.Range(0, 8);//cant remember how to grab a range - to fix


        cashA = newCharacter.character[random].cashA;
        cashB = newCharacter.character[random].cashB;
        opinionA = newCharacter.character[random].opinionA;
        opinionB = newCharacter.character[random].opinionB;
        divorceA = newCharacter.character[random].divorceA;
        divorceB = newCharacter.character[random].divorceB;
        msg = newCharacter.character[random].msg;
        updateTxt();
        resultUpdate();


    }



    public void optionA()
    {
        resources.modCash(cashA);
        resources.modDivorce(divorceA);
        resources.modOpinion(opinionA);
        updateCharacter();
    }

    public void optionB()
    {
        resources.modCash(cashB);
        resources.modDivorce(divorceB);
        resources.modOpinion(opinionB);
        resources.modOpinion(opinionB);
        updateCharacter();
    }

    private void updateTxt()
    {
        characterText.msg = msg;
        characterText.updateText(); // this is so dumb
    }


    public TMP_Text resCashA;
    public TMP_Text resCashB;
    public TMP_Text resopA;
    public TMP_Text resopB;
    public TMP_Text resdivA;
    public TMP_Text resdivB;


    public void resultUpdate()
    {
        if (cashA > 0) { resCashA.SetText("+"); }
        else if (cashA < 0) { resCashA.SetText("-"); }
        else { resCashA.SetText(""); };

        if (opinionA > 0) { resopA.SetText("+"); }
        else if (opinionA < 0) { resopA.SetText("-"); }
        else { resopA.SetText(""); };

        if (divorceA > 0) { resdivA.SetText("+"); }
        else if (divorceA < 0) { resdivA.SetText("-"); }
        else { resdivA.SetText(""); };




        if (cashB > 0) { resCashB.SetText("+"); }
        else if (cashB < 0) { resCashB.SetText("-"); }
        else { resCashB.SetText(""); };

        if (opinionB > 0) { resopB.SetText("+"); }
        else if (opinionB < 0) { resopB.SetText("-"); }
        else { resopB.SetText(""); };

        if (divorceB > 0) { resdivB.SetText("+"); }
        else if (divorceB < 0) { resdivB.SetText("-"); }
        else { resdivB.SetText(""); };

    }
    
        
}
    


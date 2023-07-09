using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardDrag : MonoBehaviour
{
    private bool isDrag = false;
    private Vector3 offset;
    private Vector3 test = new Vector3(0.0f, 0.0f, 0.0f);//test variables - important to code now so...
    private Vector3 test2 = new Vector3(0.0f, 0.0f, 0.0f);
    private Vector3 reset = new Vector3(0.0f, 0.0f, 0.0f);
    public fees score;
    public lawsuit lawsuit;
    

    private void Start()
    {
        reset = transform.position;
    }


    private void OnMouseDown()
    {
        test2.Set(Input.mousePosition.x, transform.position.y, 0);
        
        offset = transform.position - Camera.main.ScreenToWorldPoint(test2);
        isDrag = true;
    }

    private void OnMouseUp()//check choice
    {
        isDrag = false;
        if (transform.position.x >= 4) {
            //option B (right)
            Debug.Log("B");
            transform.position = reset;
            score.fee += 1000;
            lawsuit.optionB();
        }
        else if(transform.position.x <= -4) {
            //option A (left)
            Debug.Log("A");
            transform.position = reset;
            score.fee += 1000;
            lawsuit.optionA();

        };


    }

    // Update is called once per frame
    void Update()//for moving the card when it is dragged by the mouse
    {
        if (isDrag)
        {

            test.Set(Input.mousePosition.x, transform.position.y, 0);
           
            transform.position = Camera.main.ScreenToWorldPoint(test)+offset;
           

            if (transform.position.x > 5) { transform.position = new Vector3(5, transform.position.y, transform.position.z); }

            else if (transform.position.x < -5) { transform.position = new Vector3(-5, transform.position.y, transform.position.z); }
        }
        
    }
}

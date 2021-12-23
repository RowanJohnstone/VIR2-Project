using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelChoice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Canvas;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public Text ButtonText1;
    public Text ButtonText2;
    public Text ButtonText3;
    public int ChoiceMade;


    public void Start()
    {
        Canvas.SetActive(false);
        ButtonText3.text = "Hello, I really don’t feel well. I think I have a fever and my whole body hurts.";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
            Canvas.SetActive(true);
        TextBox.GetComponent<Text>().text = "Hello, what can I help you with?";
    }
    public void ChoiceOption1 ()
    {
        TextBox.GetComponent<Text>().text = "You decided to to ride your bike to school.";
        ChoiceMade = 1;
    }
    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "You decided to take the bus to school";
        ChoiceMade = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        }
    }
}

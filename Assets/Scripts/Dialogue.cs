using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    //Referencing the text fields of the dialogue field and the buttons so when the dialogue is changing I can easily change what each field says
    public Text DialogueBox;
    public Text ButtonText;
    public Text ButtonText2;
    public Text ButtonText3;

    //Referencing the buttons so I can set them as active when I need more than one button.
    public GameObject continueDialogue;
    public GameObject dialogueOption2;
    public GameObject dialogueOption3;
    public GameObject Canvas;
    //counter and string for changing the dialogue and button text.
    private int counter = 0;
    private string[] nextsentence;
    private string[] nextOption;

    void Start()
    {
        //Making the additional buttons inactive until I need them later
        dialogueOption2.SetActive(false);
        dialogueOption3.SetActive(false);

        //creates a list of four texts and saves the original as the first
        nextOption = new string[5];
        nextOption[0] = ButtonText.text;
        nextOption[1] = "Hello, I really don�t feel well. I think I have a fever and my whole body hurts.";
        nextOption[2] = "No, I don�t.";
        nextOption[3] = "There was a power outage in my area, so my computer didn�t work.";
        nextOption[4] = "Is there no one who could look at me and give me some medicine?";

        nextsentence = new string[5];
        nextsentence[0] = DialogueBox.text;
        nextsentence[1] = "Hello, I really don�t feel well. I think I have a fever and my whole body hurts.";
        nextsentence[2] = "Do you have an appointment?";
        nextsentence[3] = "Why is that? It is very easy to make an online appointment, by just going on the hospital�s website and filling in a form.";
        nextsentence[4] = "I see..It is a bit of an inconvenience, since all of our doctors have their schedules full for today�";
    }

    //cycles through the texts
    public void continueButton()
    {
        counter++;
        DialogueBox.text = nextsentence[counter];
        ButtonText.text = nextOption[counter];
        if (counter == 3)
        {
            dialogueOption2.SetActive(true);
            dialogueOption3.SetActive(true);
            ButtonText2.text = "My computer broke down.";
            ButtonText3.text = "I have difficulty reading, so it�s hard for me to access and navigate your website.";
        }
        else if (counter == 4)
        {
            dialogueOption2.SetActive(false);
            dialogueOption3.SetActive(false);
        }
        
    }
}
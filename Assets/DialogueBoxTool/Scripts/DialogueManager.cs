using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Sprite mySprite;
    public Image original;

    private Queue<string> sentences;

    
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartText (Dialogue dialogue)
    {
        sentences.Clear();
        nameText.text = dialogue.name;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }
 public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //for clearing scrolling text for the next sentence
        StopAllCoroutines();
        //scrolling text
        StartCoroutine(TypeSentence(sentence));

    }

    //for scrolling text
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        //resets to start state
        dialogueText.text = ". . . . .";
        nameText.text = ". . .";
        SpriteChange();
    }

    //to change back to a blank Sprite
    void SpriteChange()
    {
        original.sprite = mySprite;
    }
}

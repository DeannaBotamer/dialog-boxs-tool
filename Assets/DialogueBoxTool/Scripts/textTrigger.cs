using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Image original;
    public Sprite mySprite;

    public void TriggerText ()
    {
        FindObjectOfType<DialogueManager>().StartText(dialogue);
        SpriteChange();
    }

    //to change the NPC image
    void SpriteChange()
    {
        original.sprite = mySprite;
    }

}

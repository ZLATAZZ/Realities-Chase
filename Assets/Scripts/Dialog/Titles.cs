using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Titles : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textSubtitle;

    private string[] texts = new string[]
    {
        "Well, well, well player, you came to an end. Maybe, as a helpful, kind Fairy I need to congratulate you, say that you’re so brave. And now you can go home, and blah-blah-blah. ",
        "But you know that there will come a time when you believe everything is finished. That will be the beginning. Beginning of something new, not always good one, for sure, haha...And this is exactly your case. ",
        "As you may guess, you won’t go home today, tomorrow, or even at all. This reality, mine reality is your home now. And now I honestly can say congratulations, haha. ",
        "Oh, yeah, I almost forget. Maybe, you are wondering what the room is??? Oh, it my favourite room for relaxation, you can stay here for some time and vibe with the vinyl music, or go further"
        
        
    };
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeSubtitles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChangeSubtitles()
    {
        
        for(int i = 0; i < texts.Length; i++)

        {
            textSubtitle.text = texts[i];
            yield return new WaitForSeconds(14.2f);
           
        }
        //textSubtitle.text = " ";
    }
}

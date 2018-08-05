using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInstructions : MonoBehaviour {

    //A string array of text to display
    public string[] instructions;
    //The time it takes to fade out with sustained focus
    public float fadeOutTime;
    //The time it takes to fade in new text with sustained focus
    public float fadeInTime;

    private bool justStarted = false;
    private bool focused = false;
    private bool fadeOut = false;
    private int currInstructionIndex = 0;
    private float alpha = 1f;

    private Text instruction;

    //Provide a mutator for our camera raycast to tell our instructions
    //Whether they should be scrolling or not
    public void setFocused(bool isFocused){
        focused = isFocused;
    }

    public void gotFocus(){
        justStarted = true;
        focused = true;
        
    }
	// Use this for initialization
	void Start () {
        instruction = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (instructions.Length > 1)
        {
            if (focused)
            {
                //User is looking at text...
                //Find current state of text
                if (justStarted)
                {
                    //alpha is set at 1, fade out is true if more than 1 instruction
                    alpha = 1f;
                    justStarted = false;
                    fadeOut = true;
                    currInstructionIndex = 0;
                }
                if (fadeOut)
                {
                    if (alpha > 0f)
                    {
                        alpha -= Time.deltaTime / fadeOutTime;
                        if (alpha < 0f)
                        {
                            alpha = 0f;
                            fadeOut = false;
                            currInstructionIndex = (currInstructionIndex + 1) % instructions.Length;
                            instruction.text = instructions[currInstructionIndex];
                        }
                        instruction.color = new Color(instruction.color.r, instruction.color.g, instruction.color.b, alpha);
                    }
                }
                else
                {
                    if (alpha < 1f)
                    {
                        alpha += Time.deltaTime / fadeInTime;
                        if (alpha > 1f)
                        {
                            alpha = 1f;
                            fadeOut = true;
                        }
                        instruction.color = new Color(instruction.color.r, instruction.color.g, instruction.color.b, alpha);
                    }
                }
            }
        }
	}
}

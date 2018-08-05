using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionFinder : MonoBehaviour {

    public LayerMask findInstructionLayer;
    private TextInstructions focusedConversation;
    private bool inConvo = false;

    //Check if we are looking at something which is an instruction text...
    private void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, out hit, 10f, findInstructionLayer))
        {
            TextInstructions hitConversation = hit.transform.gameObject.GetComponent<TextInstructions>();
            if (focusedConversation == null){
                //We are just entering a new conversation
                focusedConversation = hitConversation;
                focusedConversation.gotFocus();
            }
            else if (focusedConversation.GetInstanceID() == hitConversation.GetInstanceID())
            {
                //We are in the same conversation as last physics frame
                focusedConversation.setFocused(true);
            }
            else{
                //We directly left one conversation to another
                focusedConversation.setFocused(false);
                focusedConversation = hitConversation;
                focusedConversation.gotFocus();

            }
            inConvo = true;
        }
        else if(inConvo){
            //We have left the active conversation
            focusedConversation.setFocused(false);
            focusedConversation = null;
            inConvo = false;
        }
    }
}

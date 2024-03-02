using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabeInteractableTwoAttach : XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;

    protected override void OnSelectEntered(SelectEnterEventArgs args){
        if(args.interactorObject.transform.CompareTag("leftHand"))
        {
            attachTransform = leftAttachTransform;
        } 
        else if(args.interactorObject.transform.CompareTag("rightHand"))
        {
            attachTransform = rightAttachTransform;
        }
        base.OnSelectEntered(args);
   }
}

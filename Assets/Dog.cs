using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Dog : VRTK_InteractableObject
{

    public override void StartUsing(VRTK_InteractUse currentUsingObject = null)
    {
        base.StartUsing(currentUsingObject);
        AnimalSelected();
        GetComponent<HighlightableObject>().FlashingOn();
        GetComponent<HighlightableObject>().OccluderOff();
    }

    public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
    {
        base.StopUsing(previousUsingObject);
        GetComponent<HighlightableObject>().FlashingOff();
        GetComponent<HighlightableObject>().OccluderOn();
    }

    public void AnimalSelected()
    {
        //AnimalController.instance.AnimalState = AnimalController.State.dog;
    }
}

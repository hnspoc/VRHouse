using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;

public class RotatorCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    private VRTK_BaseControllable ctrlable;
    public Light light1;
    public Light light2;
    private void OnEnable()
    {
        ctrlable = GetComponent<VRTK_BaseControllable>();
        ctrlable.MaxLimitReached += Controllable_MaxLimitReached;
        ctrlable.MinLimitReached += Controllable_MinLimitReached;
    }
    private void OnDisable()
    {
        ctrlable.MaxLimitReached -= Controllable_MaxLimitReached;
        ctrlable.MinLimitReached -= Controllable_MinLimitReached;
    }
    private void Controllable_MaxLimitReached(object sender, ControllableEventArgs e)
    {
        light1.enabled = false;
        light2.enabled = false;
    }
    private void Controllable_MinLimitReached(object sender, ControllableEventArgs e)
    {
       light1.enabled = true;
       light2.enabled = true;
    }
}

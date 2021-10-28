using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator_animation : MonoBehaviour, Interface_Activation
{
    // At this moment, only executable one time
    public bool used = false;

    // List to add multiple simple animations.
    public Animation[] animationList;

    public void ExecuteAction()
    {
        if (animationList.Length > 0 && !used)
        {
            for (int i = 0; i < animationList.Length; i++)
            {
                animationList[i].Play();
            }
            used = true;
        }

        else Debug.Log("No animations in the " + gameObject.name + " object");
    }
}

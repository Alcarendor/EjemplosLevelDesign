using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObject : MonoBehaviour, Interface_Activation
{
    [SerializeField]
    private CollectorObject collector;
    private void Start()
    {
        //Really fucking ugly this, in the future this will be function with events. But no time today.
        collector = GameObject.FindObjectOfType<CollectorObject>();
    }
    public void ExecuteAction()
    {
        collector.objectCollected();
        Destroy(this.gameObject);

    }
}

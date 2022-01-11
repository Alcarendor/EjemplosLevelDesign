using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlatformVerySimple : MonoBehaviour
{

    public Transform Waypoint;
    // Start is called before the first frame update
    void Start()
    {
        Tween myTween = transform.DOMove(Waypoint.position, 10);
        myTween.SetLoops(-1, LoopType.Yoyo);
        myTween.SetUpdate(UpdateType.Fixed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.parent = this.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}

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
    }

    // Update is called once per frame
    void Update()
    {

    }
}

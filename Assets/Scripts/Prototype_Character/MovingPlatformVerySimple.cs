using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlatformVerySimple : MonoBehaviour
{
    [Header("Waypoints")]
    [Tooltip("No hace falta poner el punto inicial")]
    [SerializeField] private List<Transform> Waypoints;

    [Header("Enumerados de movimiento")]
    [Tooltip("Dejar en Fixed de manera predeterminada para que funcione correctamente. Cambiar asumiendo el riesgo.")]
    public UpdateType tipoUpdate = UpdateType.Fixed;
    [Tooltip("No seleccionar nada para que haga un suavizado al acabar el movimiento. Seleccionar Linear para que no haga ningún suavizado durante los movimientos.")]
    public Ease tipoMovimiento;

    [Header("Pausa y tiempos")]
    [SerializeField] private float tiempoPausa = 0f;
    [Tooltip("Si solo se pone un elemento, se aplicará el mismo tiempo a todos los movimientos del array. Si se pone más de un tiempo pero el valor es diferente al tamaño del listado de Waypoints, dará error.")]
    [SerializeField] private List<float> listaTiempos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; 0 < Waypoints.Count; i++)
        {

        }
        //Tween myTween = transform.DOMove(Waypoint.position, 10);
        //myTween.SetLoops(-1, LoopType.Yoyo);
        //myTween.SetUpdate(UpdateType.Fixed);
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

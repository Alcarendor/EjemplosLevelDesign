using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase se utiliza para animaciones simples: o un objeto con multiples animaciones secuenciales o, en su defecto, varios objetos con una animacion cada uno.
public class Activator_animation : MonoBehaviour, Interface_Activation
{
    // At this moment, only executable one time
    [Header("Modos y usos")]
    [Tooltip("Si es true, se avanzará en el índice de animaciones y, al llegar al final, se reiniciará. En este caso, solo se necesita un elemento en la lista de animators. Si está en false, se reproducirá una animación por cada animator.")]
    public bool secuencial = false;
    [Tooltip("Si este objeto se ha utilizado alguna vez, para objetos de un solo uso")]
    public bool used = false;

    [Header("Listados")]
    [Tooltip("Lista de los animator de los diferentes objetos que se vayan a animar (en el caso de que haya múltiples objetos para animar")]
    public Animator[] AnimatorList;

    [Tooltip("Esta lista contiene los nombres de las animaciones que hay que lanzar. Deben de ser los nombres que aparecen en el Animator")]
    public string[] AnimationStateName;
    //El indice interno que utilizaremos para recorrer la lista de animaciones
    private int indiceActual = 0;

    private void Start()
    {
        if (this.tag != "Interactuable")
            throw new System.Exception("El tag del objeto debe de ser Interactuable");
        if (AnimatorList.Length != AnimationStateName.Length && !secuencial)
            throw new System.Exception("Debe de haber el mismo número de nombres que de animacioneS");
        else if (AnimatorList.Length > 1 && secuencial)
            throw new System.Exception("En el modo secuencial sólo puede haber un animator");
        
    }

    public void ExecuteAction()
    {
        if (AnimatorList.Length > 0 && !used && !secuencial)
            PlayAllAnimations();
        else if (secuencial)
            SecuencedAnimation();
        else if (AnimatorList.Length == 0)
            Debug.LogWarning("No animations in the " + gameObject.name + " object");
        else if (used)
            Debug.Log("Animación usada");
    }

    private void SecuencedAnimation()
    {
        Debug.Log(indiceActual);
        if (indiceActual > AnimatorList.Length)
        {
            indiceActual = 0;
        }
        AnimatorList[0].Play("Base Layer." + AnimationStateName[indiceActual]);
        indiceActual++;
    }

    private void PlayAllAnimations()
    {
        for (int i = 0; i < AnimatorList.Length; i++)
        {
            AnimatorList[i].Play("Base Layer." + AnimationStateName[i]);
        }
        used = true;
    }
}

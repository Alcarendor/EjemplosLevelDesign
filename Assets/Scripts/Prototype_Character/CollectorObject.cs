using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorObject : MonoBehaviour
{

    public int numeroObjetos = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Ugly, yes, but functional
        // In the future, any object will have a reference here, to store the position
        List<CollectedObject> listaColeccionables = new List<CollectedObject>(GameObject.FindObjectsOfType<CollectedObject>());
        foreach (CollectedObject go in listaColeccionables)
        {
            if (go is CollectedObject)
                numeroObjetos++;
        }
        Debug.Log("El numero de objetos es: " + numeroObjetos);
    }

    public void objectCollected()
    {
        numeroObjetos--;
        if (numeroObjetos <= 0)
        {
            Debug.Log("All object retrieved");
        }
    }



}

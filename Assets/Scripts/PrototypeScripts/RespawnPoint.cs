using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase funciona en conjuncion a Respawn.cs, solo testeada en 3D con Character Controller.
public class RespawnPoint : MonoBehaviour
{

    [SerializeField] private string playerTag = "Player";
    private RespawnManager respawnReference;
    // Start is called before the first frame update
    void Start()
    {
        respawnReference = FindObjectOfType<RespawnManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == playerTag)
        {
            respawnReference.setRespawnPoint(this);
        }
    }
}

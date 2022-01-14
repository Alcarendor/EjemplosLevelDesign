using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [Header("Explanation")]
    [SerializeField] private string descripcion = "Este elemento de respawn únicamente se puede utilizar para personajes que tengan un Character Controller";
    [Header("Respawn data")]
    [SerializeField] private string playerTag = "Player";

    private RespawnManager respawnManager;

    private void Start()
    {
        respawnManager = FindObjectOfType<RespawnManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == playerTag)
        {
            //Desactivamos el CharacterController para que no nos de el follon al hacer el teletransporte
            respawnManager.Respawn();
        }
    }

}

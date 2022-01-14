using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase funciona en conjuncion a Respawn.cs, solo testeada en 3D con Character Controller.
public class RespawnManager : MonoBehaviour
{
    //Elementos internos del sistema de respawn.
    [Header("Puntos de respawn")]
    [Tooltip("El primer punto de respawn hay que colocarlo a mano")]
    [SerializeField] public RespawnPoint lastRespawnPoint;
    [Header("Character controller")]
    [SerializeField] private CharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        //Espero que nadie tenga más de un character controller en la escena. Esto 
        if (character == null)
            character = FindObjectOfType<CharacterController>();
        if (lastRespawnPoint == null)
            Debug.LogError("No hay ningún punto de respawn activo");
    }

    public void Respawn()
    {
        character.enabled = false;
        character.transform.position = lastRespawnPoint.transform.position;
        character.enabled = true;
    }

    public void setRespawnPoint(RespawnPoint respawnPoint)
    {
        this.lastRespawnPoint = respawnPoint;
    }
}

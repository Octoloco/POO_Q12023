using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorAimee : MonoBehaviour
{
   CharacterController characterController;
    [Header("Opciones de personaje")]
     [SerializeField] public float walkSpeed = 6.0f;
     [SerializeField] public float runSpeed = 10.0f;
     [SerializeField] public float jumpSpeed = 8.0f;
     [SerializeField] public float gravity = 20.0f;
     float rotationSpeed = 50f;
}

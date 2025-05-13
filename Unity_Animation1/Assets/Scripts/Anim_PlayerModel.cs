using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_PlayerModel : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    public float MoveSpeed {  get { return moveSpeed; } set { moveSpeed = value; } }

    [SerializeField] float acceleration;
    public float Acceleration { get { return acceleration; } set { acceleration = value; } }
}

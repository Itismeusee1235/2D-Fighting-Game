using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
   [Header("Move State")]
   public float movementVelocity = 10f;
   public float runAccel = 2f;
   public float runDecel = 5f;

}

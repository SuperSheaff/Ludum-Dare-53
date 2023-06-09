using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCreatureData", menuName = "Data/Creature Data/Base Data")]

public class CreatureData : ScriptableObject
{
    [Header("Creature Stats")]
    public float baseMoveSpeed          = 50f;
    public float baseMoveSmoothing      = 0f;
    public float InteractCooldownTime   = 0.33f;
    public float baseMoveRange          = 3f;
    public float destinationThreshold   = 0.1f;

    [Header("Mood Stats")]
    public float moodDrainRate          = 1f;
    public float MelonMoodBoost         = 50f;
    public float preScremDuration       = 6.327f;
    public float scremDuration          = 7.17f;
    public float mlemDuration           = 5f;

    [Header("Egg Stats")]
    public float eggDuration            = 10f;
    public float layingEggDuration      = 3.181f;
    public float eggLayChance           = 0.01f;
    public float eggLayChanceInterval   = 5f;
    public float layingEggCooldownTime  = 20f;

}

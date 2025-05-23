using System;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveData", menuName = "Scriptable Objects/WaveData")]
public class WaveData : ScriptableObject
{
    // The name to display before spawning this wave
    [field: SerializeField]
    public string WaveName { get; private set; } = "Wave 1";
    
    // The amount of time before spawning entries
    [field: SerializeField]
    public float InitialDelay { get; private set;  }

    // The enemies to spawn
    [field: SerializeField]
    public SpawnInfo[] SpawnEntries { get; private set; } = { };
}

[Serializable]
public struct SpawnInfo
{
    // The Enemy that will spawn
    public EnemyMovement EnemyPrefab;
    // The number of enemies of thie type to spawn
    public int Count;
    // The amount of time between each one of these enemies
    public float DelayBetweenEnemy;
    // The amount of time to wait after the enemies have spawned before the next wave entry
    public float DelayAtEnd;
}

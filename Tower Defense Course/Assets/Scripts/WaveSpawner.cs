using System;
using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [field: SerializeField]
    public WaveData[] Waves { get; private set; }
    [field: SerializeField]
    public Waypoint StartingWaypoint { get; private set; }
    [SerializeField]
    private int _nextWaveIx;
    [field: SerializeField]
    public TextMeshProUGUI WaveLabel { get; private set;  }
    [field: SerializeField]
    public TextMeshProUGUI VictoryLabel { get; private set;  }

    void Awake()
    {
        _nextWaveIx = 0;
        NextWave();
    }

    private void NextWave()
    {
        if (_nextWaveIx >= Waves.Length)
        {
            Winner();
            return;
        }
        WaveData wave = Waves[_nextWaveIx++];
        StartCoroutine(WaveRoutine(wave));
    }

    private IEnumerator ShowWaveLabel(string label)
    {
        WaveLabel.text = label;
        WaveLabel.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        WaveLabel.gameObject.SetActive(false);
    }

    private IEnumerator WaveRoutine(WaveData wave)
    {
        int enemyCount = wave.SpawnEntries.Sum(s => s.Count);
        StartCoroutine(ShowWaveLabel(wave.WaveName));
        yield return new WaitForSeconds(wave.InitialDelay);

        foreach (SpawnInfo spawn in wave.SpawnEntries)
        {
            for (int count = 0; count < spawn.Count; count++)
            {
                EnemyMovement newEnemy = Instantiate(spawn.EnemyPrefab);
                newEnemy.Target = StartingWaypoint;
                Health health = newEnemy.GetComponent<Health>();
                health.OnDeath.AddListener(ReduceCountOnDeath);
                EnemyAttack attack = newEnemy.GetComponent<EnemyAttack>();
                attack.OnEnemyAttackedAndDestroyed.AddListener(ReduceCountOnAttack);
                yield return new WaitForSeconds(spawn.DelayBetweenEnemy);
            }
            yield return new WaitForSeconds(spawn.DelayAtEnd);
        }

        yield return new WaitUntil(EndCheck);
        NextWave();

        bool EndCheck() => enemyCount <= 0;
        void ReduceCountOnDeath(Health arg0) => enemyCount--;
        void ReduceCountOnAttack() => enemyCount--;
    }

    
    private void Winner()
    {
        VictoryLabel.gameObject.SetActive(true);
    }
}
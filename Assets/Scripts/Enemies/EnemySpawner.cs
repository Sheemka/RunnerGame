using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _upEnemies; //массив для префабов верхних врагов
    [SerializeField] private GameObject[] _downEnemies; //массив для префабов нижних врагов
    [SerializeField] private GameObject[] _spawnPoints; //массив для точек спавна врагов
    
    private float _spawnDelay;
    private float _startSpawnDelay = 3f;
    private int _randomEnemy;

    void Awake()
    {
        _spawnDelay = _startSpawnDelay;
    }

    void FixedUpdate()
    {
        if (_spawnDelay <= 0)
        {
            if (Random.Range(0, 10) >= 5) //тут рандомно спавню врагов
            {
                _randomEnemy = Random.Range(0, _upEnemies.Length);
                Instantiate(_upEnemies[_randomEnemy], _spawnPoints[0].transform.position, Quaternion.identity);
                _spawnDelay = _startSpawnDelay;
            }
            else
            {
                _randomEnemy = Random.Range(0, _downEnemies.Length);
                Instantiate(_downEnemies[_randomEnemy], _spawnPoints[1].transform.position, Quaternion.identity);
                _spawnDelay = _startSpawnDelay;
            }
        }
        else
        {
            _spawnDelay -= Time.deltaTime;
        }

        if (_startSpawnDelay >= 0.5f)
        {
            _startSpawnDelay -= Time.deltaTime / 300; //тут в отношении к пройденному времени уменьшаю время спавна врагов
        }
    } 
}

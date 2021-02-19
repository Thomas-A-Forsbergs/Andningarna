using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace And {
    public class SpawnManager : MonoBehaviour {
        // [SerializeField] GameObject player;
    
        [Header("And spawn times")]
        [SerializeField] GameObject _andPrefab;
        [SerializeField] float _andSpawnTime = 3f;

        // [Header("PowerUp spawn times")]
        // [SerializeField] GameObject[] _powerUps;
        // [SerializeField] float _tripleShotPowerUpSpawnTime = 3f;
        // [SerializeField] float _speedPowerUpSpawnTime = 3f;
        // [SerializeField] float _shieldPowerUpSpawnTime = 3f;

        void Start() {
            StartCoroutine(AndSpawn());
            // StartCoroutine(PowerUpTripleShotSpawn());
            // StartCoroutine(PowerUpSpeedSpawn());
            // StartCoroutine(PowerUpShieldSpawn());
        }
    
        IEnumerator AndSpawn() {
            while (true) {
                transform.position = new Vector2(Random.Range(-50f, 50f), Random.Range(-100f, 100f));
                var and = Instantiate(_andPrefab, transform.position, quaternion.identity);
                and.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
                yield return new WaitForSeconds(_andSpawnTime);
            }
        }
    
        // IEnumerator PowerUpTripleShotSpawn() {
        //     while (true) {
        //         transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(5f, 8f), 0);
        //         Instantiate(_powerUps[0], transform.position, quaternion.identity);
        //         yield return new WaitForSeconds(_tripleShotPowerUpSpawnTime);
        //     }
        // }
        //
        // IEnumerator PowerUpSpeedSpawn() {
        //     while (true) {
        //         transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(5f, 8f), 0);
        //         Instantiate(_powerUps[1], transform.position, quaternion.identity);
        //         yield return new WaitForSeconds(_speedPowerUpSpawnTime);
        //     }
        // }
        //
        // IEnumerator PowerUpShieldSpawn() {
        //     while (true) {
        //         transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(5f, 8f), 0);
        //         Instantiate(_powerUps[2], transform.position, quaternion.identity);
        //         yield return new WaitForSeconds(_shieldPowerUpSpawnTime);
        //     }
        // }
    }
}
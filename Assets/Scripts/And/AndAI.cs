using UnityEngine;
using Random = UnityEngine.Random;

namespace And {
    public class AndAI : MonoBehaviour {
        [SerializeField] float _andSpeed = 5f;
        //[SerializeField] GameObject _andExplosionPrefab;
        //[SerializeField] bool isAndExplosionAnimationActive = false;

        void Start() {
            transform.position = new Vector2(Random.Range(-50f, 50f), Random.Range(-100f, 100f));
        }

        void Update() {
            AndMovement();
            //CheckAndMovementY();
        }

        void AndMovement() {
            transform.Translate(Vector2.left * (_andSpeed * Time.deltaTime));
        }

        void CheckAndMovementY() {
            if (transform.position.y < -7f) {
                var randomRange = Random.Range(-7f, 7f);
                transform.position = new Vector2(randomRange, 7f);
            }
        }

        // void PlayAndExplosionAnimation() {
        //     Instantiate(_andExplosionPrefab, transform.position, quaternion.identity);
        //     //AndExplosionAnimationIsActive();
        // }
        //
        // public void AndExplosionAnimationIsActive() {
        //     isAndExplosionAnimationActive = true;
        //     StartCoroutine(AndExplosionAnimationCooldown());
        // }
        //
        // IEnumerator AndExplosionAnimationCooldown() {
        //     yield return new WaitForSeconds(3f);
        //     isAndExplosionAnimationActive = false;
        //     Destroy(transform.parent.gameObject);
        // }
    }
}
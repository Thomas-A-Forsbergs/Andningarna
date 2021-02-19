using UnityEngine;
using UnityEngine.EventSystems;
using Helper;
using Random = UnityEngine.Random;

namespace And {
    public class AndAI : MonoBehaviour, IPointerClickHandler {
        [SerializeField] float _speed = 30f;

        public void Start() {
            transform.position = new Vector2(Random.Range(-50f, 50f), Random.Range(-100f, 100f));
        }

        public void OnPointerClick(PointerEventData pointerEventData) {
            _speed = -_speed;
            UIManager.currentScore += 1;
            transform.Rotate(0, -180, -180);
        }

        void Update() {
            Move();
            BoundaryCheckX();
        }

        void Move() {
            transform.Translate(Vector2.right * (_speed * Time.deltaTime));
            //transform.Rotate(0, 0, 0);
        }

        void BoundaryCheckX() {
            if (transform.position.x != Mathf.Clamp(transform.position.x, 0, 500))
                Destroy(gameObject);
        }

        //[SerializeField] GameObject _andExplosionPrefab;
        //[SerializeField] bool isAndExplosionAnimationActive = false;

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
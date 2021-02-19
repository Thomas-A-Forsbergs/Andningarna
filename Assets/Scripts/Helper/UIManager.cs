using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Helper {
    public class UIManager : MonoBehaviour {
        public Text timeText;
        public float startTime;
        
        void Start() {
            startTime = 30;
        }

        void Update() {
            DisplayTime();
            IfTimerIsZeroPlayerIsDefeated();
        }

        void DisplayTime() {
            timeText.text = $"Tid kvar:\n {startTime - Time.timeSinceLevelLoad:0s}";
        }

        void IfTimerIsZeroPlayerIsDefeated() {
            if (startTime - Time.timeSinceLevelLoad <= 0) {
                SceneManager.LoadScene("Andvändare");
            }
        }
    }
}
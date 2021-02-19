using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Helper {
    public class UIManager : MonoBehaviour {
        public Text timeText;
        [SerializeField] float startTime;
        
        [SerializeField] GameObject andInstance;
        public Text scoreText;
        public short startScore;
        public short currentScore;
        [SerializeField] short _endScore;

        void Update() {
            DisplayTime();
            IfTimerIsZeroPlayerIsDefeated();
            DisplayScore();
            NextSceneIfEndScoreIsReached();
        }

        void DisplayTime() {
            timeText.text = $"Tid kvar:\n {startTime - Time.timeSinceLevelLoad:0s}";
        }

        void IfTimerIsZeroPlayerIsDefeated() {
            if (startTime - Time.timeSinceLevelLoad <= 0) SceneManager.LoadScene("Andvändare");
        }

        void DisplayScore() {
            scoreText.text = $"Vända änder:\n {currentScore}";
        }

        void NextSceneIfEndScoreIsReached() {
            if (currentScore - startScore >= _endScore)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
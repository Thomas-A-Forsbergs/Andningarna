﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Helper {
    public class UIManager : MonoBehaviour {
        public Text timeText;
        [SerializeField] float startTime;

        public Text scoreText;
        public short startScore;
        public static short currentScore;
        [SerializeField] short _endScore;

        void Update() {
            DisplayTime();
            IfTimerIsZeroPlayerIsDefeated();
            DisplayScore();
            NextSceneIfEndScoreIsReached();
            QuitButton();
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

        public void FullScreenButton() {
            Screen.fullScreen = !Screen.fullScreen;
        }

        public void ExitApplicationButton() {
            Application.Quit();
        }

        static void QuitButton() {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                Application.Quit();
            }
        }
    }
}
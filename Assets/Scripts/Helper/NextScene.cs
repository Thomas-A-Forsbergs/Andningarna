using UnityEngine;
using UnityEngine.SceneManagement;

namespace Helper {
    public class NextScene : MonoBehaviour {
        public void NextSceneButton() {
            var _activeScene = SceneManager.GetActiveScene();
            UIManager.currentScore = 0;
            SceneManager.LoadScene(_activeScene.buildIndex + 1);
        }

        public void RestartSceneButton() {
            var _activeScene = SceneManager.GetActiveScene();
            UIManager.currentScore = 0;
            SceneManager.LoadScene(_activeScene.buildIndex);
        }

        public void RestartFirstSceneButton() {
            //var _activeScene = SceneManager.GetActiveScene();
            UIManager.currentScore = 0;
            SceneManager.LoadScene("Andningarna");
        }
    }
}
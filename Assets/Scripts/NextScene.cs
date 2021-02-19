using UnityEngine;
using UnityEngine.SceneManagement;

namespace Helper {
    public class NextScene : MonoBehaviour {
        public void NextSceneButton() {
            var _activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(_activeScene.buildIndex + 1);
        }

        public void RestartSceneButton() {
            var _activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(_activeScene.buildIndex);
            Debug.Log("Active Scene is '" + _activeScene.name + "'.");
        }

        public void RestartFirstSceneButton() {
            var _activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("StartGameScene");
            Debug.Log("Active Scene is '" + _activeScene.name + "'.");
        }
    }
}
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.UI;
//
// namespace Helper {
// 	public class Hud : MonoBehaviour {
// 		public GameObject youWinMessage;
// 		public GameObject youLoseMessage;
// 		public Text playerLivesText;
//
// 		void Update() {
// 			var player = FindObjectOfType<Player>();
// 			if (player != null) {
// 				var health = player.GetComponent<Health>();
// 				if (health != null)
// 					this.playerLivesText.text = health.health.ToString("Lives: 0");
// 			}
// 		}
//
// 		public void PlayerCollectedFlag() {
// 			this.youWinMessage.SetActive(true);
// 		}
//
// 		public void ResetGame() {
// 			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
// 		}
//
// 		public void PlayerKilled() {
// 			this.youLoseMessage.SetActive(true);
// 		}
// 	}
// }


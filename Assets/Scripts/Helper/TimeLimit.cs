// using UnityEngine;
// using UnityEngine.UI;
//
// namespace Helper {
// 	public class TimeLimit : MonoBehaviour {
// 		public float timeLimitSeconds = 60f;
// 		public Text timeDisplay;
//
// 		bool IsOutOfTime => this.timeLimitSeconds <= 0f;
//
// 		void Update() {
// 			if (this.IsOutOfTime) {
// 				foreach (var player in FindObjectsOfType<Player>()) {
// 					player.SendMessage(nameof(Health.Kill), SendMessageOptions.DontRequireReceiver);
// 				}
//
// 				return;
// 			}
//
// 			this.timeLimitSeconds = Mathf.Max(0f, this.timeLimitSeconds - Time.deltaTime);
// 			this.timeDisplay.text = this.timeLimitSeconds.ToString("Time left: 00.00s");
// 		}
// 	}
// }


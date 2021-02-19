// using UnityEngine;
//
// namespace Helper {
// 	public class Health : MonoBehaviour {
// 		public int health = 3;
// 		float lastDamageTime;
//
// 		bool IsImmune => Time.time - this.lastDamageTime < 2f;
// 		bool IsDead => this.health <= 0;
//
// 		public void TakeDamage() {
// 			if (this.IsImmune)
// 				return;
// 			if (this.IsDead)
// 				return;
// 			this.lastDamageTime = Time.time;
// 			this.health--;
// 			if (this.IsDead) {
// 				TriggerDeath();
// 			}
// 		}
//
// 		public void Kill() {
// 			if (this.IsDead)
// 				return;
// 			this.health = 0;
// 			TriggerDeath();
// 		}
//
// 		void TriggerDeath() {
// 			FindObjectOfType<Hud>().PlayerKilled();
// 		}
// 	}
// }


using UnityEngine;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class BrickDestroyer : MonoBehaviour {
        public void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.CompareTag("Circle")) return;
            Destroy(gameObject);
        }
    }
}

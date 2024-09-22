using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HangingBridge
{
    public class DeathOnInteraction : MonoBehaviour
    {
        public UIManager inst;

        /// <summary>
        /// Death Trigger, when player enters trigger we end game
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Player Died: Game Over");
            }
            inst.EndGame();
        }
    }
}
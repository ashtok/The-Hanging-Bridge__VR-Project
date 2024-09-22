using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HangingBridge
{
    public class GameWonOnInteraction : MonoBehaviour
    {
        public UIManager inst;

        /// <summary>
        /// Initiates Game Won wen player triggers the collider of this gameobject
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                inst.GameWon();
            }
        }
    }
}

using System;
using LearnGame.Shooting;
using UnityEngine;

namespace LearnGame.PickUp
{
    public abstract class PickUpItem : MonoBehaviour
    {
        public event Action<PickUpItem> OnPickedUp;

        public virtual void PickUp(BaseCharacter character) {
            OnPickedUp?.Invoke(this);
        }
    }
}

using UnityEngine;

namespace LearnGame.Shooting {
    public class Bullet : MonoBehaviour
    {
        public float Damage {  get; private set; }

        private Vector3 _direction;
        private float _flySpeed;
        private float _maxFlyDistance;
        private float _currentFlyDistance;


        public void Initialize(Vector3 direction, float maxFlyDistance, float flySpeed, float damage)
        {
            _direction = direction;
            _flySpeed = flySpeed;
            _maxFlyDistance = maxFlyDistance;

            Damage = damage;
        }


        void Update()
        {
            var delta = _flySpeed * Time.deltaTime;
            _currentFlyDistance += delta;
            transform.Translate(_direction * delta);

            if (_currentFlyDistance >= _maxFlyDistance)
            {
                Destroy(gameObject);
            }
        }
    }
}
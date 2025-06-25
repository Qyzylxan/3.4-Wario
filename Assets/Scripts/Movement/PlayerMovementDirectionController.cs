using UnityEngine;

namespace LearnGame.Movement
{
    public class PlayerMovementDirectionController : MonoBehaviour, IMovementDirectionSource
    {
        private UnityEngine.Camera _camera;

        [SerializeField]
        private float runningCoefficient = 3f; // множитель для скорости при беге
        [SerializeField]
        private float run;

        public Vector3 MovementDirection {  get; private set; }

        protected void Awake()
        {
            _camera = UnityEngine.Camera.main;
        }

        protected void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            run = Input.GetKey(KeyCode.Space)? runningCoefficient: 1f;

            var direction = new Vector3(horizontal * run, 0, vertical * run);
            direction = _camera.transform.rotation * direction;
            direction.y = 0;

            MovementDirection = direction; // .normalize убран для возможности бега
        }
    }
}
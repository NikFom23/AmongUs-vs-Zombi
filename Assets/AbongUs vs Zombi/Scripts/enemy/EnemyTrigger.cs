using UnityEngine;

namespace enemy
{
    public class EnemyTrigger : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private string _tag;

        private GameObject _gameObject;
        private Rigidbody2D _rigidBody;
        private Animator _animator;

        private static readonly int isRunning = Animator.StringToHash("Run");
        private static readonly int isDie = Animator.StringToHash("Die");

        private bool _atack = false;

        private void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(_tag))
            {
                _atack = true;
                _gameObject = collision.gameObject;
                gameObject.GetComponent<TargetRotate>()._target = _gameObject;
            }
        }

        private void Update()
        {
            if (_atack == true)
            {
              
            }

        }

        private void FixedUpdate()
        {
            if (_atack == true)
            {
                Run();
                _animator.SetBool(isRunning, _atack == true);
            }
        }

        private void Run()
        {
            Vector2 direction = _gameObject.transform.position - transform.position;
            float distance = Vector2.Distance(transform.position, _gameObject.transform.position);
            _rigidBody.AddForce(direction.normalized * distance * _speed);
        }

        public void OnDieAnimate()
        {
            _animator.SetTrigger("isDie");
        }
    }

}

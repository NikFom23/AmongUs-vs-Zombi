using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Hero {

    public class HeroMove : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private GameSession _gameSession;
        [SerializeField] private Rigidbody2D _gunPosition;
        [SerializeField] private UnityEvent _actionCoins;
        [SerializeField] private UnityEvent _actionMenu;
        

        private Vector2 _movement;
        private Animator _animator;
        private Rigidbody2D _rigidBody;
        private SpriteRenderer _spriteRenderer;
        

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            StartLevelChec();
        }

        private void Update()
        {
            ReadKey();
            SpriteAnimator();        
        }


        private void FixedUpdate()
        {
            Move();
            SpriteReflectX();
        }

        private void SpriteAnimator()
        {
            _animator.SetBool("is-running", _movement.x != 0 || _movement.y != 0);
        }

        private void ReadKey()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
            if (Input.GetKeyDown(KeyCode.Escape)) 
            {
                _actionMenu.Invoke();
            }
        }

        private void Move()
        {
            _rigidBody.MovePosition(_rigidBody.position + _movement * _speed * Time.deltaTime);

        }

        private void SpriteReflectX()
        {
            if (_gunPosition.rotation > 90f || _gunPosition.rotation < -90f)
            {
                _spriteRenderer.flipX = true;
            }
            else if (_gunPosition.rotation < 90f || _gunPosition.rotation > -90f)
            {
                _spriteRenderer.flipX = false;
            }
        }

        public void  OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                _actionCoins?.Invoke();
            }
        }


        private void StartLevelChec() 
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;



            if (sceneName == "Level0.5")
            {
                _gameSession.Data._health = 4;
                _gameSession.Data._coin = 0;
                _gameSession.Data._cartridges = 60;
                _gameSession.Data._maxHeals = 4;


            }
        }



    }

}
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;

    private int currentPointIndex = 0;
    private Animator _animator;
    private static readonly int isRunning = Animator.StringToHash("Run");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_points.Length > 0)
        {
            // Перемещение объекта к текущей точке с использованием MoveTowards
            MoveTowardsPoint(_points[currentPointIndex]);

            // Если объект достаточно близко к текущей точке
            if (Vector3.Distance(transform.position, _points[currentPointIndex].position) < 0.05f)
            {
                // Останавливаем объект точно в позиции точки
                transform.position = _points[currentPointIndex].position;

                // Переход к следующей точке
                currentPointIndex = (currentPointIndex + 1) % _points.Length;

                // Триггерим анимацию
                _animator.SetTrigger(isRunning);
            }
        }
    }

    private void MoveTowardsPoint(Transform targetPoint)
    {
        // Используем MoveTowards для более точного движения
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, _speed * Time.deltaTime);
    }

    // Метод для изменения ориентации объекта при столкновении с точкой
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _points[currentPointIndex])
        {
            // Изменение ориентации объекта на ротацию следующей точки
            transform.rotation = _points[currentPointIndex].rotation;
        }
    }
}
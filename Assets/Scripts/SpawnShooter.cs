using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShooter : MonoBehaviour
{
    [SerializeField] private float flightDurationInSeconds = 2;

    private Spawn _currentSpawn;
    [SerializeField] private GameObject gun;
    private Camera _mainCamera;
    private bool _isShot;


    private void Start()
    {
        _mainCamera = Camera.main;
    }


    public void ChangeCurrentSpawn(Spawn NewSpawn)
    {
        _currentSpawn = NewSpawn;
        _isShot = false;
    }


    void Update()
    {
        if (_isShot)
            return;
        
        if (Input.GetMouseButton(0))
        {
            RotateTowardsTarget();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }
    


    // private void ShootWithVelocity(Vector3 targetPosition)
    // {
    //     _currentSpawn.MoveWithVelocity(targetPosition - _currentSpawn.transform.position / flightDurationInSeconds);
    //     _isShot = true;
    // }

    void ShootWithVelocity(Vector3 targetPos)
    {
        Vector3 movementVector = (targetPos - _currentSpawn.transform.position);
        _currentSpawn.MoveWithVelocity(movementVector / flightDurationInSeconds);
    }


    void RotateTowardsMouse(Vector3 targetPos)
    {
        Vector3 directionVector = (targetPos - gun.transform.position);
        gun.transform.forward = directionVector;
    }

    void RotateTowardsTarget()
    {
        RaycastHit hit;
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            RotateTowardsMouse(hit.point);
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            ShootWithVelocity(hit.point);
        }
    }
}

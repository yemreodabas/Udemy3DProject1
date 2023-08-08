using System.Collections;
using System.Collections.Generic;
using Udemy3DProject.Inputs;
using UnityEngine;

namespace Udemy3DProject.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float force;
        Rigidbody rigidbody;
        DefaultInput input;

        bool isForceUp;

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
            input = new DefaultInput();
        }

        private void Update()
        {
            if(input.isForceUp)
            {
                isForceUp = true;
            }
            else
            {
                isForceUp = false;
            }
        }

        private void FixedUpdate()
        {
            //Fizik iþlemleri
            if(isForceUp)
            {
                rigidbody.AddForce(Vector3.up * Time.deltaTime * force);
            }
        }
    }
}


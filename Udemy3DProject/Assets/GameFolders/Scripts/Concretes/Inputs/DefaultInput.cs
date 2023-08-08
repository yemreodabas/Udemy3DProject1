using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Udemy3DProject.Inputs
{
    public class DefaultInput
    {
        DefaultAction input;

        public bool isForceUp { get; private set; }
        public DefaultInput()
        {
            input = new DefaultAction();

            input.Rocket.ForceUp.performed += context => isForceUp = context.ReadValueAsButton();

            input.Enable();
        }
    }
}


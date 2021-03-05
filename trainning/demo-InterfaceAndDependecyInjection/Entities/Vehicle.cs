using System;

namespace demo_InterfaceAndDependecyInjection.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle ( string model )
        {
            Model = model;
        }
    }
}

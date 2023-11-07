///////////////////////////////////////////////////////////////////////////////
//
// Author: Melanie Magno, magnomk@etsu.edu && Tyler Campbell, campbellt5@etsu.edu && Jacob Klucher, klucher@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project3
// File Name: Warehouse.cs
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProjTest
{
    internal class Warehouse
    {
        public List<Dock> Docks { get; set; }
        public Queue<Truck> Entrance { get; set; }

        public Warehouse()
        {
            Docks = new List<Dock>();
            Entrance = new Queue<Truck>();
        }

        public void Run()
        {
            //this is probably where we could start creating the new trucks and adding them to the Dock line etc. or calling other methods from here to do that

            //need a while loop for trucks to appear, need to create a random number generator
            //using NextDouble() then compare that to predetermined percentages based on what time of day it is
            //use bell curve for the chance of a truck to show up. If it is less than 24 increments, then divide the current increment by 24
            //if it is over 24, divide that number minus 24 by 24

        }

        //create a method that returns a csv file
        //create a time increment variable that starts at 0 and ends at the end of the day (should be 47)
        //in crate unload method, need to check the time increment variable
        //In crate unload method (or somewhere like that, there needs to be a string that is returned if a crate is unloaded:
        //crate unloaded, but there are still more trucks to unload
        //crate unloaded, truck is empty AND another truck is in the dock
        //crate unloaded, truck is empty AND there is NOT another truck in the dock

        //potentially need to eventually create new method that opens new docks as it gets closer to noon and closes docks as it gets further away
    }
}

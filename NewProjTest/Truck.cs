﻿///////////////////////////////////////////////////////////////////////////////
//
// Author: Melanie Magno, magnomk@etsu.edu && Tyler Campbell, campbellt5@etsu.edu && Jacob Klucher, klucher@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project3
// File Name: Truck.cs
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProjTest
{
    internal class Truck
    {
        public string Driver { get; set; }
        public string DeliveryCompany { get; set; }
        private Stack<Crate> Trailer;

        /// <summary>
        /// creates a truck with a driver and company sponsor and stack of crates
        /// </summary>
        /// <param name="driver">the driver of this truck</param>
        /// <param name="deliveryCompany">the company the truck is shipping for</param>
        public Truck(string driver, string deliveryCompany)
        {
            this.Driver = driver;
            this.DeliveryCompany = deliveryCompany;
            Trailer = new Stack<Crate>();
        }

        /// <summary>
        /// loads/adds a crate into a truck's crate stack
        /// </summary>
        /// <param name="crate">a crate being put into a truck</param>
        public void Load(Crate crate)
        {
            Trailer.Push(crate);
        }

        /// <summary>
        /// removes a crate from a truck's stack/trailer
        /// </summary>
        /// <returns>the crate at the top of the stack</returns>
        public Crate Unload()
        {
            return Trailer.Pop();
        }
    }
}

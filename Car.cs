﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ObligatoriskOpgave_4
{
    public class Car
    {
        private int _id;
        private string _model;
        private int _price;
        private string _licensePlate;


        public Car(int id, string model, int price, string licensePlate)
        {

            Id = id;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }

        public string LicensePlate { get; set; }

        public int Price { get; set; }

        public string Model { get; set; }

        public int Id { get; set; }

        public Car()
        {
        }
    }
}


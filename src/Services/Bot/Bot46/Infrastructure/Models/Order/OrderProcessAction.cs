﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bot46.API.Infrastructure.Models
{
    public class OrderProcessAction
    {
        public string Code { get; private set; }
        public string Name { get; private set; }

        public static OrderProcessAction Ship = new OrderProcessAction(nameof(Ship).ToLowerInvariant(), "Ship");

        protected OrderProcessAction()
        {
        }

        public OrderProcessAction(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
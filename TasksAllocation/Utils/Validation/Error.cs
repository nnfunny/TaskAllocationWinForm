﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksAllocation.Utils.Validation
{
    class Error
    {
        public string Message { get; set; }
        public string ActualValue { get; set; }
        public string ExpectedValue { get; set; }

        public Error()
        {

        }

        public Error(string message, string actualValue, string expectedValue)
        {
            Message = message;
            ActualValue = actualValue;
            ExpectedValue = expectedValue;
        }
    }
}

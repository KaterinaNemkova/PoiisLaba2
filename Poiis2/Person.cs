﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiis2._0
{
    public abstract class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }
    }
}

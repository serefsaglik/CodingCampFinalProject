﻿using Enities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enities.Concrete
{
    //Çıplak Class Kalmasın (ÇCK)
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kebabhouse
{
    public class skladnik
    {
        public void DisplayMaso(List<sklad> veci)
        {
            foreach(var vec in veci)
            {
                Console.WriteLine("");
                
                Console.WriteLine($"maso: {vec.Maso}");
                
            }
        
        }
        
        
    
    
    }
}

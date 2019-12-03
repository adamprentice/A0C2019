﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode.Models.Responses._2019
{
    public class Day3Response : BaseResponse
    {
        public Day3Response(double answer1, int answer2)
        {
            this.Answer1 = answer1.ToString();
            this.Answer2 = answer2.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Workflow
    {
        public string Name { get; set; }
        public List<Questionnaire> Questionnaires { get; set; }
    }
}

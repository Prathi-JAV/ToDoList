﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TodoList
    {
        //Adding columns to the model
        public int Id { get; set; } 
        [Required]
        public string Content { get; set; }
    }
}

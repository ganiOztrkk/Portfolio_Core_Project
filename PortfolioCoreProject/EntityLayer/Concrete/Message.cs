﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Message
	{
        [Key]
        public int MessageId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool ReadStatus { get; set; }
        public bool MessageStatus { get; set; }
    }
}


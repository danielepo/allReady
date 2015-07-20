﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrepOps.Models
{
    public class TaskUsers
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public PrepOpsTask Task { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime StatusDateTimeUtc { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }

        public string StatusDescription { get; set; }

    }
}
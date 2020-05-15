﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BitchPlease.Models
{
    public class UserGroup
    {
        public long UserId { get; set; }
        public User User { get; set; }

        public long GroupId { get; set; }
        public Group Group { get; set; }


        public static void ModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserGroup>()
                .HasKey(ug => new { ug.UserId, ug.GroupId });
        }
    }
}
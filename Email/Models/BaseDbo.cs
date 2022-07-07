using System;
using System.ComponentModel.DataAnnotations;


    public abstract class BaseDbo
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; }
    }


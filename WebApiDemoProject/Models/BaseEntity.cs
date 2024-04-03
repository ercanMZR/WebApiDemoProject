﻿namespace WebApiDemoProject.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }= false;
        public DateTime CreatedDate { get; set; }
    }
}

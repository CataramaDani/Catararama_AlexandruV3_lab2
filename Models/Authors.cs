﻿namespace Catararama_AlexandruV3_lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}

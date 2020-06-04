using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bigschool.Models;

namespace bigschool.Models
{
    public class coures
    {
        public int Id { get; set; }
        public ApplicationUser lecturer { get; set; }
        public string lecturerID { get; set; }
        public string place { get; set; }
        public DateTime datetime { get; set; }
        public Category category { get; set; }
        public byte categoryId { get; set; }
    }
    public class category
    {
        public byte ID { get; set; }
        public string Name { get; set; }
    }
}
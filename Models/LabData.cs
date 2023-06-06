using System;

namespace pavlovLab.Models
{
    public class LabData
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte NumberGroup { get; set; }
        public string Cipher { get; set; }
        public string Mail {get;set;}
    }
}
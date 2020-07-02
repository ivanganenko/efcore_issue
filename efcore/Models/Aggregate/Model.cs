using System.Collections.Generic;

namespace EFCore.Models.Aggregate
{
    public class Model
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public List<Email> Emails { get; set; }
    }
}
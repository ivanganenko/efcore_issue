using System.Collections.Generic;
using EFCore.Data;
using EFCore.Models.Aggregate;

namespace EFCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new MyDbContext();
            var service = new Service(context);

            var model = new Model
            {
                Emails = new List<Email>
                {
                    new Email("test1@", EmailType.Primary, EmailStatus.Unverified),
                    new Email("test2@", EmailType.Additional, EmailStatus.Used),
                    new Email("test3@", EmailType.Newsletter, EmailStatus.Verified)
                },
                FirstName = "FN"
            };

            service.Add(model);

            service.GetListQuery();
        }
    }
}
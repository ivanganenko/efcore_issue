using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EFCore.Models.Aggregate;

namespace EFCore.Models.Api
{
    public class ModelApi
    {
        public static readonly Expression<Func<Model, ModelApi>> SelectExpression = m => new ModelApi
        {
            Id = m.Id,
            FirstName = m.FirstName,
            //If only code with FirstOrDefault expression is removed (Email), the code works as expected.
            Email = m.Emails
                .FirstOrDefault(
                    e =>
                        e.Type == EmailType.Primary && e.Status != EmailStatus.Used)
                .EmailString,
            //If remove FirstOrDefault expression, code works with string interpolation
            InterpolatedString = "test" + m.FirstName,
            //If code with non-empty list initialization is removed, the code works as expected.
            Collection = new List<string>
            {
                $"{m.FirstName}@test1.com",
                $"{m.FirstName}@test2.com",
                $"{m.FirstName}@test3.com",
                $"{m.FirstName}@test4.com"
            }
        };

        public int Id { get; private set; }


        public string FirstName { get; private set; }


        public string Email { get; private set; }


        public ICollection<string> Collection { get; private set; }


        public string InterpolatedString { get; private set; }
    }
}
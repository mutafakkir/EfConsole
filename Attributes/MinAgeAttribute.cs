using System;
using System.ComponentModel.DataAnnotations;

namespace efconsole.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MinAgeAttribute : ValidationAttribute
    {
        private int _minAge;
        public MinAgeAttribute(int MinAge)
        {
            _minAge = MinAge;
        }
        public override bool IsValid(object value)
        {
            var birthdate = (DateTimeOffset)value;
            return birthdate > DateTimeOffset.Now.AddYears(-_minAge);
        }
    }
}
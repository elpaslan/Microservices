using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeCourse.Services.Order.Domain.Core;

namespace FreeCourse.Services.Order.Domain.OrderAggregate
{
    public class Address:ValueObject
    {
        public string Province { get; private set; }

        public string District { get; private set; }

        public string Street { get; private set; }

        public string ZipCode { get; private set; }

        public string Line { get; private set; }

        public Address(string line, string zipCode, string street, string district, string province)
        {
            Line = line;
            ZipCode = zipCode;
            Street = street;
            District = district;
            Province = province;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Province;
            yield return District;
            yield return Street;
            yield return ZipCode;
            yield return Line;
        }
    }
}

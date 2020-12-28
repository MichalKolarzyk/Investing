using BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class ForkAlgorithm : IAlgorithm
    {
        public Company Company { get; private set; }

        public string Description => throw new NotImplementedException();

        public ForkAlgorithm(Company company)
        {
            Company = company;
        }
        public IAlgorithmResult GetResult()
        {
            throw new NotImplementedException();
        }
    }
}

using System;

using R5T.T0142;
using R5T.T0187;


namespace R5T.T0207
{
    [DataTypeMarker]
    public class SolutionSpecification : ISolutionSpecification
    {
        public ISolutionName SolutionName { get; set; }
    }
}

using System;

using R5T.T0142;
using R5T.T0204;


namespace R5T.T0207
{
    [DataTypeMarker]
    public class WebBlazorClientAndServerSolutionSpecification : SolutionSpecification
    {
        public IProjectSpecification BlazorClientProjectSpecification { get; set; }
        public IProjectSpecification ServerProjectSpecification { get; set; }
    }
}

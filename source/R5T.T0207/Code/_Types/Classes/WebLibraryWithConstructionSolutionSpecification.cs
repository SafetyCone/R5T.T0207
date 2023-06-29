using System;

using R5T.T0142;
using R5T.T0204;


namespace R5T.T0207
{
    [DataTypeMarker]
    public class WebLibraryWithConstructionSolutionSpecification : SolutionSpecification
    {
        public IProjectSpecification WebLibraryProjectSpecification { get; set; }
        public IProjectSpecification BlazorClientProjectSpecification { get; set; }
        public IProjectSpecification ServerProjectSpecification { get; set; }
    }
}

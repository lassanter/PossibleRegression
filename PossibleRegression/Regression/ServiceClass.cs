// <copyright file="ServiceClass.cs" company="Cybertrol Software Services">
//     Copyright (c) Cybertrol Software Services. All rights reserved.
// </copyright>

namespace PossibleRegression.Regression;

public class ServiceClass
{
    private List<ServiceResult> _data;

    public ServiceClass()
    {
        int id = 1;
        _data = new List<ServiceResult>
        {
            new ServiceResult(id++, "Gloria Hamilton"),
            new ServiceResult(id++, "Jason Williamson"),
            new ServiceResult(id++, "Catherine Noble"),
            new ServiceResult(id++, "Idris Dunlap"),
            new ServiceResult(id++, "Iliana Randall"),
            new ServiceResult(id++, "Trenton Rojas"),
            new ServiceResult(id++, "Adaline Rivers"),
            new ServiceResult(id++, "Bear Barton"),
            new ServiceResult(id++, "Danna Heath"),
            new ServiceResult(id++, "Lionel Thomas"),
            new ServiceResult(id++, "Elizabeth Fields"),
            new ServiceResult(id++, "Clayton Barber"),
            new ServiceResult(id++, "Cassidy Reilly"),
            new ServiceResult(id++, "Alvaro May"),
            new ServiceResult(id++, "Adriana Stevenson"),
            new ServiceResult(id++, "Callan Houston"),
            new ServiceResult(id++, "Lylah Douglas"),
            new ServiceResult(id++, "Derek Chan"),
            new ServiceResult(id++, "Hattie Sullivan"),
            new ServiceResult(id++, "Evan Peralta")
        };
    }

    public ValueTask<IEnumerable<ServiceResult>> FindByPartial(string argsFilter)
    {
        IEnumerable<ServiceResult> result = _data.Where(result => result.Name.Contains(argsFilter));
        return new ValueTask<IEnumerable<ServiceResult>>(result);
    }
}

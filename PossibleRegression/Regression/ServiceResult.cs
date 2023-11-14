// <copyright file="ServiceResult.cs" company="Cybertrol Software Services">
//     Copyright (c) Cybertrol Software Services. All rights reserved.
// </copyright>

namespace PossibleRegression.Regression;

public class ServiceResult
{
    public ServiceResult(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; }
    public string Name { get; }
}

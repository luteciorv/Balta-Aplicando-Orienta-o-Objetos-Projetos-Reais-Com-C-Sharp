﻿namespace UtmBuilder.Core.ValueObjects;

public class Campaign : ValueObject
{
    public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;

        Id = id;
        Term = term;
        Content = content;
    }

    public string? Id { get; set; }
    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string? Term { get; set; }
    public string? Content { get; set; }
}
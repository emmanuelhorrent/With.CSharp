﻿namespace With.CSharp.Tests.ClassPatterns
{
    public class Mutable
    {
        public string FirstField { get; set; }
        public string SecondField { get; set; }

        public Mutable(string firstField, string secondField)
        {
            this.FirstField = firstField;
            this.SecondField = secondField;
        }
    }
}

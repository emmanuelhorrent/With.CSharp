﻿using System;
using System.Collections.Generic;

namespace With.Query
{
    /// <summary>
    /// Provides informations to create and update an immutable instance
    /// </summary>
    /// <typeparam name="T">Type of the instance to copy and update</typeparam>
    public class CopyUpdateQuery<T>
        where T : class
    {
        /// <summary>
        /// Wrapped instance
        /// </summary>
        public readonly T Source;

        /// <summary>
        /// Values to update (key = field/property name)
        /// </summary>
        public readonly IEnumerable<KeyValuePair<string, object>> MemberValues;

        /// <summary>
        /// Create an instance of <see cref="T:CreateUpdateQuery"/> type
        /// </summary>
        /// <param name="source">Instance to wrap</param>
        /// <param name="memberValues">Values to update (key = field/property name)</param>
        public CopyUpdateQuery(T source, IEnumerable<KeyValuePair<string, object>> memberValues)
        {
            if (null == source) throw new ArgumentNullException("source");
            if (null == memberValues) throw new ArgumentNullException("memberValues");

            this.Source = source;
            this.MemberValues = memberValues;
        }
    }
}
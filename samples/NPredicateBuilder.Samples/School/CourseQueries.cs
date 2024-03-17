// <copyright file="CourseQueries.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

namespace NPredicateBuilder.Samples.School
{
    /// <summary>
    /// Sample query object for the <see cref="Course"/> class.
    /// </summary>
    internal class CourseQueries : BaseQuery<Course>
    {
        /// <summary>
        /// Checks to see if a course has a requirement that must be taken before.
        /// </summary>
        /// <returns>The query object.</returns>
        public CourseQueries OrIsPrerequisite()
        {
            AddOrCriteria(course => course.HasPrerequisite);

            return this;
        }
    }
}
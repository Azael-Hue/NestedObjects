using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The legal first and last name of the advisor
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The adviusors work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number where the advisor's office is located
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}

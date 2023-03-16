using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SATProject.DATA.EF.Models//MetaData
{
    public class Partials
    {

        [ModelMetadataType(typeof(CourseMetaData))]
        public partial class Course { }

        [ModelMetadataType(typeof(EnrollmentMetaData))]
        public partial class Enrollment { }


        [ModelMetadataType(typeof(ScheduledClassMetaData))]
        public partial class ScheduledClass { }


        [ModelMetadataType(typeof(ScheduledClassStatusMetaData))]
        public partial class ScheduledClassStatus { }

        [ModelMetadataType(typeof(StudentMetaData))]
        public partial class Student { }


        [ModelMetadataType(typeof(StudentStatusMetaData))]
        public partial class StudentStatus { }


    }
}

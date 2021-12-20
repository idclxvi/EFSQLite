using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFSQLite.Models
{

    [Table("users")]
    public class User
    {

        public int Id { get; set; }

        [Required,MinLength(5),MaxLength(20)]
        public string Name { get; set; }
    }
}

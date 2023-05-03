using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Eya_Dellai_Ala_app.Models
{
    public class FirstModel : Controller
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [MaxLength(5000)]
        public string Body { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }


        [Display(Name = "Updated At")]
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }

    }
}

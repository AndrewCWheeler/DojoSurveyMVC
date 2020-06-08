using System.ComponentModel.DataAnnotations;
namespace DojoSurveyMVC.Models

{
    public class Survey 
    {   
        [Required]
        [MinLength(2)]
        public string Name {get; set;}

        [Required]
        public string Dojo_Location {get; set;}

        [Required]
        public string Favorite_Language {get; set;}

        [MaxLength(20)]
        public string Comment {get; set;}
    }
}
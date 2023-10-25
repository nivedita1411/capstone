using System.ComponentModel.DataAnnotations;

public class Product
{
    [Display(Name = "Product Id")]
    [Key]
    [Required(ErrorMessage ="Id is required")]
    public int Id{get;set;}
    [Required(ErrorMessage ="Name cannot be blanked")]
    [Range(100,900,ErrorMessage ="Price should be between 100 and 900")]
    public string Name{get;set;}
    public int Price {get;set;}
    public int Stock{get;set;}
}


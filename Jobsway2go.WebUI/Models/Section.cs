using System;
using System.ComponentModel.DataAnnotations;

[DataContract]
public class Section
{
    [DataMember]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [String]
    public string Name { get; set; }

    [Required(ErrorMessage = "Location is required")]
    [String]
    public string Location { get; set; }

    [DisplayFormat(DataFormatString = "{0:d}")]
    public DateTime DateFrom { get; set; }

    [DisplayFormat(DataFormatString = "{0:d}")]
    public DateTime DateTo { get; set; }

}
using System;
using System.ComponentModel.DataAnnotations;

[DataContract]
public class Section
{
    [DataMember]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

}
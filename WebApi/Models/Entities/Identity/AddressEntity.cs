﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities.Identity;

public class AddressEntity
{
    [Key]
    public int Id { get; set; }
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    public ICollection<UserProfileEntity> Users { get; set; } = new List<UserProfileEntity>();
}

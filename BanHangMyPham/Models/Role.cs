using System;
using System.Collections.Generic;

namespace BanHangMyPham.Models;

public partial class Role
{
    public int RolesId { get; set; }

    public string? RoleName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}

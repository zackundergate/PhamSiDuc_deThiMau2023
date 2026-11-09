using System;
using System.Collections.Generic;

namespace PhamSiDuc_deThiMau2023.Models;

public partial class TblAccount
{
    public int Uid { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
}

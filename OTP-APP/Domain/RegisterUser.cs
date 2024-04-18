using System;
using System.Collections.Generic;

namespace OTP_APP.Domain;

public partial class RegisterUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;
}

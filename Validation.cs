using System;
using System.Text.RegularExpressions;
using Phone_Book.Lawang.Models;

namespace Phone_Book.Lawang;

public static class Validation
{
    public static bool IsEmailValid(string email)
    {
        return Regex.IsMatch(email,  @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$", RegexOptions.IgnoreCase);
    }

    public static bool IsNumberValid(string number)
    {
        return Regex.IsMatch(number, @"^(\+[0-9]{10})$");
    }

    public static bool IsIdValid(IEnumerable<Contact> contacts, int id)
    {
        var contact = contacts.FirstOrDefault(x => x.Id == id);
        return contact != null; 
    }
}

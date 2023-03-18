 int AgeCalculator(DateTime birthdayDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthdayDate.Year;

    if (birthdayDate > today.AddYears(-age))
    {
        age--;
    }

    return age;
}
